using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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

        public CourseController(context context)
        {
            _context = context;
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


        // GET: /Course/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
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
                    CompletionStatus = CompletionStatus.InProgress,
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

            var course = await _context.Courses.Include(c => c.Instructor).FirstOrDefaultAsync(c => c.Id == id && !EF.Property<bool>(c, "Deleted")); // Check if not deleted

            if (course == null)
            {
                return NotFound();
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

            if (ModelState.IsValid)
            {
                try
                {
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




        // GET: /Course/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Retrieve the course while ignoring query filters
            var course = await _context.Courses
                .IgnoreQueryFilters() // Ignore filters to find by ID regardless of deletion status
                .FirstOrDefaultAsync(m => m.Id == id);

            if (course == null)
            {
                return NotFound();
            }

            // Check if the course is marked as deleted using the shadow property
            // Note: No await here; accessing a shadow property is synchronous
            if (_context.Entry(course).Property<bool>("Deleted").CurrentValue)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: /Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // Retrieve the course while ignoring query filters
            var course = await _context.Courses
                .IgnoreQueryFilters() // Ensure we can find the course regardless of deletion status
                .FirstOrDefaultAsync(m => m.Id == id);

            if (course == null)
            {
                return NotFound();
            }

            // Set the shadow property to true for soft delete
            _context.Entry(course).Property("Deleted").CurrentValue = true;

            // Optionally mark the entity as modified (not always necessary)
            _context.Courses.Update(course);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        // Helper method to check if a course exists
        private bool CourseExists(int id)
        {
            // Check for non-deleted courses
            return _context.Courses.Any(e => e.Id == id && !EF.Property<bool>(e, "Deleted"));
        }
    }
}
