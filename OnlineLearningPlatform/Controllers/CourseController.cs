using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using OnlineLearningPlatform.App.interfaces;
using OnlineLearningPlatform.Entities.Models;
using OnlineLearningPlatform.Helpers;
using OnlineLearningPlatform.Models;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private readonly context _context;
        private readonly UserManager<AppUser> _userManager;
        private IWebHostEnvironment _environment;
        private IUploudFile _uploadFile;

        public CourseController(context context, UserManager<AppUser> userManager, IWebHostEnvironment environment, IUploudFile uploadFile)
        {
            _context = context;
            _userManager = userManager;
            _environment = environment;
            _uploadFile = uploadFile;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("Course")]
        public async Task<IActionResult> Index()
        {
            var courses = await _context.Courses.ToListAsync();   // dah when the user not searching  (NO Search String Input)
                                                                  // This function will show me all the couses in tne DB 
            return View(courses);
        }


        [AllowAnonymous]
        [HttpGet]
        [Route("Course/Search")]
        public async Task<IActionResult> Index(string searchString)  // dah b2a will be executed lma yb2a feh input in the search
        {
            var courses = from c in _context.Courses select c;  // Retrieve all courses from the Courses table
                                                                // in the DB - that contains search string -

            // Check if a search string was provided 
            if (!String.IsNullOrEmpty(searchString))
            {
                courses = courses.Where(c => c.Name.Contains(searchString));
            }

            // store the search string in ViewData 3lshan law ht3mle tla2e el input bta3k lsa mogod
            ViewData["CurrentFilter"] = searchString;

            return View(await courses.ToListAsync());
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("Course/Filter/{category}")]
        public async Task<IActionResult> Filter(Category? category)
        {
            // Get the list of courses
            var courses = from c in _context.Courses
                          select c;

            // If a category is selected, filter by category
            if (category != null)
            {
                courses = courses.Where(c => c.Category == category);
            }

            // Retrieve the filtered list
            var filteredCourses = await courses.ToListAsync();

            return View("Index", filteredCourses); 
        }


        // GET: /Course/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .Include(c=>c.Lessons)
                .Include(c => c.Instructor)
                .ThenInclude(i => i.AppUser)
                
                .FirstOrDefaultAsync(c => c.Id == id && !EF.Property<bool>(c, "Deleted")); // Check if not deleted

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Student")]
        public async Task<IActionResult> Enroll(int courseId)
        {
            // Get the StudentId from claims
            var studentIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var studentId = GetStudentIdFromDatabase(studentIdClaim);

            // Check if the student is already enrolled in the course
            var existingEnrollment = await _context.Enrollments
                .FirstOrDefaultAsync(e => e.CourseId == courseId && e.StudentId == studentId);

            if (existingEnrollment != null)
            {
                ViewBag.Message = "You are already enrolled in this course.";
                return View(await _context.Courses.FindAsync(courseId));
            }
            else
            {
                var enrollment = new Enrollment
                {
                    CourseId = courseId,
                    StudentId = studentId,
                    EnrollmentDate = DateTime.Now,
                    CompletionStatus = CompletionStatus.NotStarted,
                    Progress = 0,
                };

                _context.Enrollments.Add(enrollment);

                // Increment the enrollment count for the course
                var course = await _context.Courses.FindAsync(courseId);
                if (course != null)
                {
                    course.EnrollmentCount++; // Increment the enrollment count by one
                }
                await _context.SaveChangesAsync();

                //****** Fill LessonCompletions Entity

                // Fetch all lesson IDs
                var lessonIds = await _context.Lessons
                    .Where(l => l.CourseId == courseId) 
                    .Select(l => l.Id) 
                    .ToListAsync();

                // Add LessonCompletions for each lesson
                foreach (var lessonId in lessonIds)
                {
                    var lessonCompletion = new LessonCompletion
                    {
                        EnrollmentId = enrollment.Id, 
                        LessonId = lessonId,
                        IsCompleted = false 
                    };

                    _context.LessonCompletions.Add(lessonCompletion);
                }

               
                await _context.SaveChangesAsync();

                //******


                ViewBag.Message = "You have successfully enrolled in the course.";
            }
            return View(await _context.Courses.FindAsync(courseId));
        }

        // Helper method to retrieve StudentId from the database
        private int GetStudentIdFromDatabase(string studentId)
        {
            var student = _context.Students.FirstOrDefault(s => s.AppUserId == studentId);
            return student?.Id ?? 0;
        }

        // GET: /Course/Create
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create()
        {
            var instructors = await _context.Instructors.Include(i => i.AppUser).ToListAsync();
            ViewData["instructors"] = instructors;
            return View();
        }

        // POST: /Course/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(Course course)
        {
            if (ModelState.IsValid)
            {
                if (course.ImageFile != null)
                {
                    string FilePath = await _uploadFile.UploadFileAsync("\\Images\\CoursesImages\\", course.ImageFile);
                    course.Image = FilePath;
                }

                _context.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }




        // GET: /Course/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .Include(c => c.Instructor)
                .FirstOrDefaultAsync(c => c.Id == id && !EF.Property<bool>(c, "Deleted")); // Check if not deleted

            if (course == null)
            {
                return NotFound();
            }

            // Ensure instructors can only edit their own courses
            if (User.IsInRole("Instructor"))
            {
                var instructorId = await _context.Instructors
                    .Where(i => i.AppUserId == _userManager.GetUserId(User))
                    .Select(i => i.Id)
                    .FirstOrDefaultAsync();

                if (course.InstructorId != instructorId)
                {
                    return Unauthorized();
                }
            }

            var instructors = await _context.Instructors.Include(i => i.AppUser).ToListAsync();
            ViewBag.instructors = instructors;
            ViewBag.DifficultyLevels = new SelectList(Enum.GetValues(typeof(DifficultyLevel)));

            return View(course);
        }

        // POST: /Course/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, Course course)
        {
            if (id != course.Id)
            {
                return NotFound();
            }

            // Ensure instructors can only edit their own courses
            if (User.IsInRole("Instructor"))
            {
                var instructorId = await _context.Instructors
                    .Where(i => i.AppUserId == _userManager.GetUserId(User))
                    .Select(i => i.Id)
                    .FirstOrDefaultAsync();

                if (course.InstructorId != instructorId)
                {
                    return Unauthorized();
                }
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (course.ImageFile != null)
                    {
                        string FilePath = await _uploadFile.UploadFileAsync("\\Images\\CoursesImages\\", course.ImageFile);
                        course.Image = FilePath;
                    }
                    _context.Update(course);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(course.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            var instructors = await _context.Instructors.Include(i => i.AppUser).ToListAsync();
            ViewBag.instructors = instructors;
            ViewBag.DifficultyLevels = new SelectList(Enum.GetValues(typeof(DifficultyLevel)));

            return View(course);
        }



        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Instructor")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await _context.Courses.IgnoreQueryFilters().FirstOrDefaultAsync(m => m.Id == id);

            if (course == null)
            {
                return NotFound();
            }

            // Ensure instructors can only delete their own courses
            if (User.IsInRole("Instructor"))
            {
                var instructorId = await _context.Instructors
                    .Where(i => i.AppUserId == _userManager.GetUserId(User))
                    .Select(i => i.Id)
                    .FirstOrDefaultAsync();

                if (course.InstructorId != instructorId)
                {
                    return Unauthorized();
                }
            }

            // Soft delete - set the shadow property 'Deleted' to true
            _context.Entry(course).Property("Deleted").CurrentValue = true;
            _context.Courses.Update(course);
            await _context.SaveChangesAsync();

            // Redirect based on the user role
            if (User.IsInRole("Instructor"))
            {
                return RedirectToAction("MyCourses", "Course");
            }

            return RedirectToAction(nameof(Index));
        }




        // Helper method to check if a course exists
        private bool CourseExists(int id)
        {
           
            return _context.Courses.Any(e => e.Id == id && !EF.Property<bool>(e, "Deleted"));
        }


        [Authorize(Roles = "Instructor")]
        public async Task<IActionResult> MyCourses()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            IQueryable<Course> courses = _context.Courses
                .Include(c => c.Instructor)
                .ThenInclude(i => i.AppUser);
            
                var instructorId = await _context.Instructors
                    .Where(i => i.AppUserId == userId)
                    .Select(i => i.Id)
                    .FirstOrDefaultAsync();

                courses = courses.Where(c => c.InstructorId == instructorId);
                      
            return View(await courses.ToListAsync());
        }

    }
}
