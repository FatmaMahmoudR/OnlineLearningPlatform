using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Entities.Models;
using OnlineLearningPlatform.Models;

namespace OnlineLearningPlatform.App.Controllers
{
    [Authorize(Roles = "Instructor")]
    public class LessonController : Controller
    {
         private readonly context _context;
        private readonly UserManager<AppUser> _userManager; 

        public LessonController(context context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager; 
        }

     
        // GET: /Lesson/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var lesson = await _context.Lessons
                .Include(l => l.Course) 
                .FirstOrDefaultAsync(l => l.Id == id);

            if (lesson == null || lesson.Course.InstructorId != (await _context.Instructors.Where(i => i.AppUserId == _userManager.GetUserId(User)).Select(i => i.Id).FirstOrDefaultAsync()))
            {
                return NotFound();
            }

            return View(lesson);
        }



        /// <summary>
        /// Displays the create lesson view for a specific course. 
        /// It checks if the current instructor is authorized to create a lesson 
        /// for the specified course.
        /// </summary>
        /// <param name="courseId">The ID of the course for which a lesson is being created.</param>
        /// <returns>Returns the create lesson view with the course ID, 
        /// or a 404 NotFound result if the course is not found.</returns>

        // GET: /Lesson/Create?courseId=1
        public async Task<IActionResult> Create(int courseId)
        {
            var instructorId = await _context.Instructors
                .Where(i => i.AppUserId == _userManager.GetUserId(User))
                .Select(i => i.Id)
                .FirstOrDefaultAsync();

            var course = await _context.Courses.FirstOrDefaultAsync(c => c.Id == courseId && c.InstructorId == instructorId);
            if (course == null)
            {
                return NotFound();
            }
            ViewBag.CourseId = courseId;
            var lesson = new Lesson();
            return View(lesson);
        }


        /// <summary>
        /// Submits a new lesson for a course, validates the data, and creates lesson completion records for enrollments.
        /// </summary>
        /// <param name="lesson">The lesson object containing details for creation.</param>
        /// <returns>Course details view on success, or create lesson view with validation errors if invalid.</returns>


        // POST: /Lesson/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Lesson lesson)
        {
            if (ModelState.IsValid)
            {
                lesson.Course = await _context.Courses.FirstOrDefaultAsync(c => c.Id == lesson.CourseId);
                _context.Lessons.Add(lesson);
                await _context.SaveChangesAsync();

                var crs_id = lesson.CourseId;

                var Enrollments = await _context.Enrollments.Where(e=>e.CourseId== crs_id).ToListAsync();

                var e_ids = Enrollments.Select(e => e.Id).ToList();
                foreach(var i in e_ids)
                {
                    LessonCompletion lessonCompletion = new LessonCompletion();
                    lessonCompletion.LessonId = lesson.Id;
                    lessonCompletion.EnrollmentId = i;

                    _context.LessonCompletions.Add(lessonCompletion);
                    await _context.SaveChangesAsync();

                    // Mark the course as modified ---> to update progress value
                    lesson.Course.Modified = true;
                    _context.Courses.Update(lesson.Course);
                    await _context.SaveChangesAsync();

                }

                return RedirectToAction("Details", "Course", new { id = lesson.CourseId });

                
            }
            ViewBag.CourseId = lesson.CourseId;
            return View(lesson);
        }


        /// <summary>
        /// Displays the edit view for a lesson, checking instructor authorization.
        /// </summary>
        /// <param name="id">The lesson ID.</param>
        /// <returns>Returns the edit view or 404 if not found.</returns>
        // GET: /Lesson/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            // Include the Course when loading the Lesson
            var lesson = await _context.Lessons
                .Include(l => l.Course)
                .FirstOrDefaultAsync(m => m.Id == id && !EF.Property<bool>(m, "Deleted"));


            if (lesson == null)
            {
                return NotFound();
            }

            // Check if the current user is the instructor of the course
            var instructorId = await _context.Instructors
                .Where(i => i.AppUserId == _userManager.GetUserId(User))
                .Select(i => i.Id)
                .FirstOrDefaultAsync();

            if (lesson.Course.InstructorId != instructorId)
            {
                return Forbid();
            }

            ViewBag.CourseId = lesson.CourseId;
            return View(lesson);
        }


        /// <summary>
        /// Processes changes to a lesson, checking authorization and redirecting on success.
        /// </summary>
        /// <param name="id">The lesson ID.</param>
        /// <param name="lesson">The updated lesson data.</param>
        /// <returns>Redirects to course details or shows the edit view on errors.</returns>
        // POST: /Lesson/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Lesson lesson)
        {
            if (id != lesson.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    var currLesson = await _context.Lessons
                        .Include(l => l.Course)
                        .FirstOrDefaultAsync(l => l.Id == id);

                    if (currLesson == null)
                    {
                        return NotFound();
                    }

                    // Check if the current user is the instructor of the course
                    var instructorId = await _context.Instructors
                        .Where(i => i.AppUserId == _userManager.GetUserId(User))
                        .Select(i => i.Id)
                        .FirstOrDefaultAsync();

                    if (currLesson.Course.InstructorId != instructorId)
                    {
                        return Forbid();
                    }

                    currLesson.Title = lesson.Title;
                    currLesson.FilePath = lesson.FilePath;

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LessonExists(lesson.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction("Details", "Course", new { id = lesson.CourseId });
            }

            return View(lesson);
        }


        private bool LessonExists(int id)
        {
            return _context.Lessons.Any(e => e.Id == id);
        }


        /// <summary>
        /// Marks a lesson as deleted, checking instructor authorization before deletion.
        /// </summary>
        /// <param name="id">The lesson ID.</param>
        /// <returns>Redirects to the course details or returns 404 if not found or unauthorized.</returns>
        // POST: /Lesson/Delete/5 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            // Fetch the lesson along with its course
            var lesson = await _context.Lessons
                .Include(l => l.Course)
                .FirstOrDefaultAsync(l => l.Id == id && !EF.Property<bool>(l, "Deleted"));

            // Check if the lesson exists and if the user is the instructor
            if (lesson == null || lesson.Course.InstructorId !=
                (await _context.Instructors
                    .Where(i => i.AppUserId == _userManager.GetUserId(User))
                    .Select(i => i.Id)
                    .FirstOrDefaultAsync()))
            {
                return NotFound();
            }

            // Perform the soft delete by marking the 'Deleted' property
            _context.Entry(lesson).Property("Deleted").CurrentValue = true;
            await _context.SaveChangesAsync();

            // Mark the course as modified ---> to update progress value
            lesson.Course.Modified = true;
            _context.Courses.Update(lesson.Course);
            await _context.SaveChangesAsync();

            // Redirect back to the course's details page
            return RedirectToAction("Details", "Course", new { id = lesson.CourseId });
        }




    }
}
