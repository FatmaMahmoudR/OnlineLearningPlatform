﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Entities.Models;
using OnlineLearningPlatform.Helpers;
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



        /// <summary>
        /// Retrieves the details of a specific enrollment for the current student.
        /// Returns a NotFound result if the course ID is missing, the student is not found, or not enrolled in the course.
        /// </summary>
        /// <param name="id">The course ID.</param>
        /// <returns>The enrollment details view or an error message.</returns>
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
                .Include(e=>e.LessonCompletions)
				.FirstOrDefaultAsync(e => e.StudentId == std_id && e.CourseId == id && !EF.Property<bool>(e.Course, "Deleted"));

			if (enrollment == null)
			{
				return NotFound("You are not enrolled in this course.");
			}

			return View(enrollment);
		}



        /// <summary>
        /// Displays the current student's enrolled courses and their progress.
        /// Returns a NotFound result if the student is not found or has no enrollments.
        /// Updates progress and completion status for modified courses.
        /// </summary>
        /// <returns>The view of the student's enrollments.</returns>
        public async Task<IActionResult> MyLearning()
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
                .Include(e => e.LessonCompletions)
                .ToListAsync();

            if (enrollments == null)
            {
                return NotFound("You are not enrolled in this course.");
            }
            //if any modified course --> re-calc Progress & change status 
            foreach(var e in enrollments)
            {
                if (e.Course.Modified == true)
                {
                    UpdateProgress(e.Id);
                    changeCompletionStatus(e.Id);

                }

            }
            //enrollments.FirstOrDefault(e => e.Id == 1).Progress=0;

            return View(enrollments);
        }



        /// <summary>
        /// Marks a lesson as completed for a specific enrollment.
        /// Returns a success or error response based on the operation's outcome.
        /// </summary>
        /// <param name="enrollmentId">The enrollment ID.</param>
        /// <param name="lessonId">The lesson ID.</param>
        /// <returns>A response indicating success or failure.</returns>
        [HttpPost("Enrollment/MarkLessonCompleted/{enrollmentId}/{lessonId}")]
        public async Task<IActionResult> MarkLessonCompleted(int enrollmentId, int lessonId)
        {
            var currentUser = await _userManager.GetUserAsync(User);

            var student = await _context.Students
                .Include(s => s.Enrollments)
                .FirstOrDefaultAsync(s => s.AppUserId == currentUser.Id);

            if (enrollmentId <= 0 || lessonId <= 0)
            {
                return BadRequest(new { success = false, message = "Invalid enrollment or lesson ID." });
            }

            
            var enrollment = await _context.Enrollments
                .Include(e => e.Course)
                .ThenInclude(c => c.Lessons)
                .Include(e => e.LessonCompletions) 
                .FirstOrDefaultAsync(e => e.Id == enrollmentId && e.StudentId == student.Id);

            if (enrollment != null)
            {
                var lesson = enrollment.Course.Lessons.FirstOrDefault(l => l.Id == lessonId);

                if (lesson != null)
                {
                    var lessonCompletion = enrollment.LessonCompletions
                        .FirstOrDefault(lc => lc.LessonId == lessonId);

                    if (lessonCompletion == null)
                    {
                        lessonCompletion = new LessonCompletion
                        {
                            EnrollmentId = enrollmentId,
                            LessonId = lessonId,
                            IsCompleted = true
                        };
                        enrollment.LessonCompletions.Add(lessonCompletion); 
                    }
                    else
                    {
                        lessonCompletion.IsCompleted = true;
                    }

                    await _context.SaveChangesAsync();

                    // update progress 
                    UpdateProgress(enrollmentId);

                    // change enrollment completion status
                    changeCompletionStatus(enrollmentId);

                    return Ok(new { success = true });
                }
                else
                {
                    return BadRequest(new { success = false, message = "Lesson not found in this enrollment." });
                }
            }

            return BadRequest(new { success = false, message = "Enrollment not found." });
        }



        /// <summary>
        /// Calculates and updates the progress percentage of lessons completed for a given enrollment.
        /// Throws an exception if the enrollment is not found.
        /// </summary>
        /// <param name="enrollmentId">The enrollment ID.</param>
        //After lesson completion || id course is modified
        public void UpdateProgress(int enrollmentId)
        {
            var enrollment = _context.Enrollments
                .Include(e => e.Course)
                .ThenInclude(c => c.Lessons)
                .Include(e => e.LessonCompletions)
                .FirstOrDefault(e => e.Id == enrollmentId);

            if (enrollment == null)
            {
                throw new Exception("Enrollment not found.");
            }

            int totalLessons = enrollment.Course.Lessons.Count;

            int completedLessons = enrollment.LessonCompletions
                .Count(lc => lc.IsCompleted);

            double progress = ((double)completedLessons / totalLessons) * 100;

            
            enrollment.Progress = (int)progress;
            _context.SaveChanges();
        }



        /// <summary>
        /// Updates the completion status of an enrollment based on the number of completed lessons.
        /// Throws an exception if the enrollment is not found.
        /// </summary>
        public void changeCompletionStatus(int enrollmentId)
        {
            var enrollment = _context.Enrollments
                .Include(e => e.Course)
                .ThenInclude(c => c.Lessons)
                .Include(e => e.LessonCompletions)
                .FirstOrDefault(e => e.Id == enrollmentId);

            if (enrollment == null)
            {
                throw new Exception("Enrollment not found.");
            }
            
            

            int totalLessons = enrollment.Course.Lessons.Count;

            int completedLessons = enrollment.LessonCompletions
                .Count(lc => lc.IsCompleted);

            if(completedLessons == 0)
            {
                enrollment.CompletionStatus = CompletionStatus.NotStarted;
                
            }else if(completedLessons == totalLessons)
            {
                enrollment.CompletionStatus = CompletionStatus.Completed;
                
            }
            else
            {
                enrollment.CompletionStatus = CompletionStatus.InProgress;
                
            }
            _context.SaveChanges();


        }









    }


}

