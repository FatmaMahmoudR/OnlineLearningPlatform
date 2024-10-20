using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
        private IGenericRepository<Course> _repository;
        private IGenericRepository<Enrollment> _enrollmentRepository;
        private IGenericRepository<Lesson> _lessonRepository;
        private IGenericRepository<LessonCompletion> _lessonCompletionRepository;
        private IGenericRepository<Student> _studentRepository;
        private IGenericRepository<Instructor> _instructorRepository;

        private readonly UserManager<AppUser> _userManager;
        private IWebHostEnvironment _environment;
        private IUploudFile _uploadFile;

        public CourseController(
            IGenericRepository<Course> repository,
            IGenericRepository<Enrollment> enrollmentRepository,
            IGenericRepository<LessonCompletion> lessonCompletionRepository,
            IGenericRepository<Student> studentRepository,
            IGenericRepository<Instructor> instructorRepository,
            IGenericRepository<Lesson> lessonRepository,
            UserManager<AppUser> userManager,
            IWebHostEnvironment environment,
            IUploudFile uploadFile)
        {
            _repository = repository;
            _enrollmentRepository = enrollmentRepository;
            _lessonCompletionRepository = lessonCompletionRepository;
            _lessonRepository = lessonRepository;
            _studentRepository = studentRepository;
            _instructorRepository = instructorRepository;
            _userManager = userManager;
            _environment = environment;
            _uploadFile = uploadFile;
        }




        /// <summary>
        /// Displays a list of courses. Admins can see all courses, 
        /// while anonymous users, students, and instructors can only see published courses.
        /// </summary>
        /// <returns>Returns the view containing the list of courses.</returns>
        [AllowAnonymous]
        [HttpGet]
        [Route("Course")]
        public async Task<IActionResult> Index() 
        {
            var courses = await _repository.GetAllAsync();

            if (!User.Identity.IsAuthenticated  || User.IsInRole("Student") || User.IsInRole("Instructor"))
            {
                courses = courses.Where(c =>c.Published == true).ToList();

            }
            return View(courses);
        }

        /// <summary>
        /// Displays a list of courses with an optional search filter. 
        ///  Filters courses by name if a search string is provided.
        /// </summary>
        /// <param name="searchString"> The search term to filter courses by name.</param>
        /// <returns>Returns the view containing the filtered list of courses.</returns>

        [AllowAnonymous]
        [HttpGet]
        [Route("Course/Search")]
        public async Task<IActionResult> Index(string searchString)
        {
            var courses = await _repository.GetAllAsync();

            if (!User.Identity.IsAuthenticated  || User.IsInRole("Student") || User.IsInRole("Instructor"))
            {
                courses = courses.Where(c => c.Published).ToList();
            }

            if (!string.IsNullOrEmpty(searchString))
            {
                courses = courses.Where(c => c.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList();
            }


            ViewData["CurrentFilter"] = searchString;

            return View(courses);
        }




        [AllowAnonymous]
        [HttpGet]
        [Route("Course/Filter/{category}")]
        public async Task<IActionResult> Filter(Category? category)
        {
            var courses = await _repository.GetAllAsync();

            if (category != null)
            {
                courses = courses.Where(c => c.Category == category).ToList();
            }

            return View("Index", courses);
        }


        /// <summary>
        /// Displays the details of a specific course, including its lessons and instructor information. 
        /// Ensures that the course is not marked as deleted.
        /// </summary>
        /// <param name="id">The ID of the course to display details for.</param>
        /// <returns>Returns the course details view if found, otherwise returns a 404 NotFound result.</returns>

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var course = await _repository.GetAllAsync(
                c => c.Id == id && !EF.Property<bool>(c, "Deleted"),
                new[] { "Lessons", "Instructor.AppUser" });

            if (course == null) return NotFound();

            return View(course.FirstOrDefault());
        }



        /// <summary>
        /// Handles the enrollment of a student in a specified course. 
        /// It checks if the student is already enrolled; if not, it creates a new enrollment record, 
        /// updates the course's enrollment count, and initializes lesson completions for the course.
        /// </summary>
        /// <param name="courseId">The ID of the course the student wishes to enroll in.</param>
        /// <returns>Returns the course details view with a success or informational message.</returns>

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Student")]
        public async Task<IActionResult> Enroll(int courseId)
        {
            var studentIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var studentId = await GetStudentIdFromDatabase(studentIdClaim);

            // Check if the student is already enrolled in the course
            var existingEnrollment = await _enrollmentRepository
                .GetAllAsync(e => e.CourseId == courseId && e.StudentId == studentId);

            if (existingEnrollment != null && existingEnrollment.Any())
            {
                ViewBag.Message = "You are already enrolled in this course.";
                return View(await _repository.GetByIdAsync(courseId));
            }

            // Create new enrollment if not already enrolled
            var enrollment = new Enrollment
            {
                CourseId = courseId,
                StudentId = studentId,
                EnrollmentDate = DateTime.Now,
                CompletionStatus = CompletionStatus.NotStarted,
                Progress = 0,
            };

            await _enrollmentRepository.AddAsync(enrollment);

            var course = await _repository.GetByIdAsync(courseId);
            if (course != null)
            {
                course.EnrollmentCount++;
                await _repository.UpdateAsync(course);
            }

            // Retrieve lessons for the course
            var lessons = await _lessonRepository.GetAllToListAsync(l => l.CourseId == courseId);

            // Add lesson completions individually using the repository's AddAsync method
            foreach (var lesson in lessons)
            {
                var lessonCompletion = new LessonCompletion
                {
                    EnrollmentId = enrollment.Id,
                    LessonId = lesson.Id,  // Accessing Id property directly
                    IsCompleted = false
                };

                await _lessonCompletionRepository.AddAsync(lessonCompletion);
            }

            ViewBag.Message = "You have successfully enrolled in the course.";
            return View(await _repository.GetByIdAsync(courseId));
        }

        private async Task<int> GetStudentIdFromDatabase(string studentId)
        {
            var student = await _studentRepository
                .GetAllAsync(s => s.AppUserId == studentId);

            return student.FirstOrDefault()?.Id ?? 0;
        }



        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create()
        {
            var instructors = await _instructorRepository.GetAllAsync(null, new[] { "AppUser" });
            ViewData["instructors"] = instructors;
            return View();
        }



        /// <summary>
        /// Handles the creation of a new course by an admin. 
        /// It validates the course data, uploads an associated image if provided, 
        /// and adds the course to the repository. If successful, it redirects to the course index.
        /// </summary>
        /// <param name="course">The course object containing the details of the course to be created.</param>
        /// <returns>Returns the course index view on successful creation, or the course creation view with validation errors if invalid.</returns>

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

                await _repository.AddAsync(course);
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }


        /// <summary>
        /// Displays the edit view for a specific course, allowing an admin to modify course details.
        /// Retrieves the course by its ID.
        /// </summary>
        /// <param name="id">The ID of the course to be edited.</param>
        /// <returns>Returns the edit view for the course if found; otherwise, returns a 404 NotFound result.</returns>

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var course = await _repository.GetAllAsync(
                c => c.Id == id && !EF.Property<bool>(c, "Deleted"),
                new[] { "Instructor.AppUser" });
            if (course == null) return NotFound();


            //if (User.IsInRole("Instructor"))
            //{
            //    var instructorId = await _instructorRepository.GetAllAsync(
            //        i => i.AppUserId == _userManager.GetUserId(User));
            //    if (course.FirstOrDefault()?.InstructorId != instructorId.FirstOrDefault()?.Id) return Unauthorized();
            //}

            var instructors = await _instructorRepository.GetAllAsync(null, new[] { "AppUser" });
            ViewBag.instructors = instructors;
            ViewBag.DifficultyLevels = new SelectList(Enum.GetValues(typeof(DifficultyLevel)));
            return View(course.FirstOrDefault());
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        /// <summary> 
        /// It validates the course data, uploads a new image if provided, 
        /// If successful, it redirects to the course index.
        /// </summary>
        /// <param name="id">The ID of the course being edited.</param>
        /// <param name="course">The course object containing the updated details.</param>
        /// <returns>Returns the course index view on successful update, 
        /// or the edit view with validation errors if invalid.</returns>

        public async Task<IActionResult> Edit(int id, Course course)
        {
            if (id != course.Id) return NotFound();

            //if (User.IsInRole("Instructor"))
            //{
            //    var instructorId = await _instructorRepository.GetAllAsync(i => i.AppUserId == _userManager.GetUserId(User));
            //    if (course.InstructorId != instructorId.FirstOrDefault()?.Id) return Unauthorized();
            //}

            if (ModelState.IsValid)
            {
                if (course.ImageFile != null)
                {
                    string FilePath = await _uploadFile.UploadFileAsync("\\Images\\CoursesImages\\", course.ImageFile);
                    course.Image = FilePath;
                }
                await _repository.UpdateAsync(course);
                return RedirectToAction(nameof(Index));
            }

            var instructors = await _instructorRepository.GetAllAsync(null, new[] { "AppUser" });
            ViewBag.instructors = instructors;
            ViewBag.DifficultyLevels = new SelectList(Enum.GetValues(typeof(DifficultyLevel)));
            return View(course);
        }



        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // Fetch the course with no filters to allow soft delete
            var course = await _repository.GetWithNoFiltersAsync(id);

            if (course == null)
            {
                return NotFound();
            }

            // Perform soft delete using the repository
            await _repository.SoftDeleteAsync(id);

           
            return RedirectToAction(nameof(Index));
        }


        /// <summary>
        /// Displays the courses associated with the currently logged-in instructor. 
        /// </summary>
        /// <returns>Returns the view containing the instructor's courses, 
        /// or a 404 NotFound result if the instructor is not found.</returns>

        [Authorize(Roles = "Instructor")]
        public async Task<IActionResult> MyCourses()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var instructor = (await _instructorRepository.GetAllAsync(i => i.AppUserId == userId)).FirstOrDefault();

            if (instructor == null)
            {
                return NotFound("Instructor not found");
            }

            var courses = await _repository.GetAllAsync(c => c.InstructorId == instructor.Id);

            return View(courses);
        }


        /// <summary>
        /// Publishes a specific course, allowing the instructor to make it available 
        /// to students. It checks that the instructor is the owner of the course 
        /// before marking it as published.
        /// </summary>
        /// <param name="id">The ID of the course to be published.</param>
        /// <returns>Returns the MyCourses view on successful publication, 
        /// or a 404 NotFound result if the course is not found, 
        /// or an Unauthorized result if the instructor does not own the course.</returns>

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Instructor")]
        public async Task<IActionResult> Publish(int id)
        {
            var course = await _repository.GetByIdAsync(id);

            if (course == null)
            {
                return NotFound();
            }

            var instructorId = await _instructorRepository.GetAllAsync(i => i.AppUserId == _userManager.GetUserId(User));
                

            // Check if the current user is the instructor of the course
            if (instructorId.FirstOrDefault()?.Id != course.InstructorId)
            {
                return Unauthorized(); 
            }

            // Mark the course as published
            course.Published = true;
            await _repository.UpdateAsync(course);

            //success response
            return RedirectToAction("MyCourses", "Course");
        }

    }
}
