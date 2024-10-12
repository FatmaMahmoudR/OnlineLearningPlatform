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

        //// GET: /Lesson/Index?courseId=1
        //public async Task<IActionResult> Index(int courseId)
        //{
        //    var instructorId = await _context.Instructors
        //        .Where(i => i.AppUserId == _userManager.GetUserId(User))
        //        .Select(i => i.Id)
        //        .FirstOrDefaultAsync();

        //    var course = await _context.Courses
        //                               .Include(c => c.Lessons)
        //                               .FirstOrDefaultAsync(c => c.Id == courseId && c.InstructorId == instructorId && !EF.Property<bool>(c, "Deleted"));

        //    if (course == null)
        //    {
        //        return NotFound();
        //    }

        //    ViewBag.CourseId = courseId;
        //    ViewBag.CourseTitle = course.Name;
        //    return View(course.Lessons);
        //}

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
                return RedirectToAction("Details", "Course", new { id = lesson.CourseId });

                
            }
            ViewBag.CourseId = lesson.CourseId;
            return View(lesson);
        }

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
                    // Include the Course when loading the Lesson
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

                    // Update the lesson's properties
                    currLesson.Title = lesson.Title;
                    currLesson.FilePath = lesson.FilePath;
                    currLesson.Iscompleted = lesson.Iscompleted;

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

                // Redirect to the course details page
                return RedirectToAction("Details", "Course", new { id = lesson.CourseId });
            }

            return View(lesson);
        }

        private bool LessonExists(int id)
        {
            return _context.Lessons.Any(e => e.Id == id);
        }

        // GET: /Lesson/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var lesson = await _context.Lessons.Include(l => l.Course)
                .FirstOrDefaultAsync(l => l.Id == id && !EF.Property<bool>(l, "Deleted"));

            if (lesson == null || lesson.Course.InstructorId != (await _context.Instructors.Where(i => i.AppUserId == _userManager.GetUserId(User)).Select(i => i.Id).FirstOrDefaultAsync()))
            {
                return NotFound();
            }

            return View(lesson);
        }

        // POST: /Lesson/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lesson = await _context.Lessons.FindAsync(id);
            if (lesson != null)
            {
                // Soft delete using shadow property
                _context.Entry(lesson).Property("Deleted").CurrentValue = true;
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Details", "Course", new { id = lesson.CourseId });
        }

     

    }
}
