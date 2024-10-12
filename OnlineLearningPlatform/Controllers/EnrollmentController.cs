using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Entities.Models;
using OnlineLearningPlatform.Models;
using System.Net;
using System.Security.Claims;

namespace OnlineLearningPlatform.App.Controllers
{
	[Authorize(Roles = "Student")]
	public class EnrollmentController : Controller
	{

		private readonly context _context;
		private readonly UserManager<AppUser> _userManager;
		public EnrollmentController(context context, UserManager<AppUser> userManager)
		{
			_context = context;
			_userManager = userManager;
		}


		//Enrollment/Details/1
		public async Task<IActionResult> Details(int? id) //crs id
		{
			if (id == null)
			{
				return NotFound("Course ID is required.");
			}

			var currentUser = await _userManager.GetUserAsync(User);

			// the student associated with the current user
			var student = await _context.Students
				.Include(s => s.Enrollments)
				.FirstOrDefaultAsync(s => s.AppUserId == currentUser.Id);

			if (student == null)
			{
				return NotFound("You Are Not Student");
			}

			int std_id = student.Id;

			
			var enrollment = await _context.Enrollments
				.Include(e => e.Course)
					.ThenInclude(c => c.Lessons)
				.Include(e => e.Course.Instructor)
				.Include(e => e.Course.Instructor.AppUser)
				.Include(e => e.Student)
					.ThenInclude(i => i.AppUser)
				.FirstOrDefaultAsync(e => e.StudentId == std_id && e.CourseId == id && !EF.Property<bool>(e.Course, "Deleted"));

			if (enrollment == null)
			{
				return NotFound("You are not enrolled in this course.");
			}

			return View(enrollment);
		}


        public async Task<IActionResult> MyCourses()
        {
            var currentUser = await _userManager.GetUserAsync(User);

            var student = await _context.Students
                .Include(s => s.Enrollments)
                .FirstOrDefaultAsync(s => s.AppUserId == currentUser.Id);

            if (student == null)
            {
                return NotFound("You Are Not Student");
            }

            int std_id = student.Id;

            var enrollments = await _context.Enrollments
				.Where(e => e.StudentId == std_id) 
				.Include(e => e.Course) 
				.Include(e => e.Course.Instructor) 
			    .Include(e => e.Course.Instructor.AppUser) 
				.ToListAsync();

            if (enrollments == null)
            {
                return NotFound("You are not enrolled in this course.");
            }

            return View(enrollments);
        }



		[HttpPost]
		public async Task<IActionResult> MarkLessonCompleted(int enrollmentId, int lessonId)
		{
			// Validate input parameters
			if (enrollmentId <= 0 || lessonId <= 0)
			{
				return BadRequest(new { success = false, message = "Invalid enrollment or lesson ID." });
			}

			
			var enrollment = await _context.Enrollments
										   .Include(e => e.Course)
										   .ThenInclude(c => c.Lessons)
										   .FirstOrDefaultAsync(e => e.Id == enrollmentId);

			if (enrollment != null)
			{
				
				var lesson = enrollment.Course.Lessons.FirstOrDefault(l => l.Id == lessonId);

				if (lesson != null)
				{
					lesson.Iscompleted = true;
					await _context.SaveChangesAsync(); 
					return Ok(new { success = true });
				}
			}

			return BadRequest(new { success = false, message = "Enrollment or lesson not found." });
		}
	
	










	}


}

