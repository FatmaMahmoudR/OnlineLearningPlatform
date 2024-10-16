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

        [AllowAnonymous]
        [HttpGet]
        [Route("Course")]
        public async Task<IActionResult> Index()
        {
            var courses = await _repository.GetAllAsync();
            return View(courses);
        }


        [AllowAnonymous]
        [HttpGet]
        [Route("Course/Search")]
        public async Task<IActionResult> Index(string searchString)
        {
            var courses = await _repository.GetAllAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                courses = courses.Where(c => c.Name.Contains(searchString)).ToList();
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


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var course = await _repository.GetAllAsync(
                c => c.Id == id && !EF.Property<bool>(c, "Deleted"),
                new[] { "Lessons", "Instructor.AppUser" });
            if (course == null) return NotFound();

            return View(course.FirstOrDefault());
        }

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

            if (existingEnrollment.Any())
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

            // Retrieve lessons and associate them with the new enrollment
            var lessonIds = await _lessonRepository.GetAllAsync(l => l.CourseId == courseId);

            foreach (var lesson in lessonIds)
            {
                var lessonCompletion = new LessonCompletion
                {
                    EnrollmentId = enrollment.Id,
                    LessonId = lesson.Id,
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

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var course = await _repository.GetAllAsync(
                c => c.Id == id && !EF.Property<bool>(c, "Deleted"),
                new[] { "Instructor.AppUser" });
            if (course == null) return NotFound();

            if (User.IsInRole("Instructor"))
            {
                var instructorId = await _instructorRepository.GetAllAsync(
                    i => i.AppUserId == _userManager.GetUserId(User));
                if (course.FirstOrDefault()?.InstructorId != instructorId.FirstOrDefault()?.Id) return Unauthorized();
            }

            var instructors = await _instructorRepository.GetAllAsync(null, new[] { "AppUser" });
            ViewBag.instructors = instructors;
            ViewBag.DifficultyLevels = new SelectList(Enum.GetValues(typeof(DifficultyLevel)));
            return View(course.FirstOrDefault());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, Course course)
        {
            if (id != course.Id) return NotFound();

            if (User.IsInRole("Instructor"))
            {
                var instructorId = await _instructorRepository.GetAllAsync(i => i.AppUserId == _userManager.GetUserId(User));
                if (course.InstructorId != instructorId.FirstOrDefault()?.Id) return Unauthorized();
            }

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
        [Authorize(Roles = "Admin, Instructor")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // Fetch the course with no filters to allow soft delete
            var course = await _repository.GetWithNoFiltersAsync(id);

            if (course == null)
            {
                return NotFound();
            }

            // Ensure instructors can only delete their own courses
            if (User.IsInRole("Instructor"))
            {
                var instructorId = await _instructorRepository.GetAllAsync(i => i.AppUserId == _userManager.GetUserId(User));
                if (instructorId.FirstOrDefault()?.Id != course.InstructorId)
                {
                    return Unauthorized();
                }
            }

            // Perform soft delete using the repository
            await _repository.SoftDeleteAsync(id);

            // Redirect based on the user role
            if (User.IsInRole("Instructor"))
            {
                return RedirectToAction("MyCourses", "Course");
            }

            return RedirectToAction(nameof(Index));
        }


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

    }
}
