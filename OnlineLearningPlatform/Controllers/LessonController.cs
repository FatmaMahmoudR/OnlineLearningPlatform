using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Entities.Models;
using OnlineLearningPlatform.Models;

namespace OnlineLearningPlatform.App.Controllers
{

    [Authorize(Roles ="Instructor")]
    public class LessonController : Controller
    {
        private readonly context _context;

        public LessonController(context context)
        {
            _context = context;
        }

        // GET: Module
        // GET: /Module/Index?courseId=1
        public async Task<IActionResult> Index(int courseId)
        {
            var course = await _context.Courses
                                       .Include(c => c.Lessons)
                                       .FirstOrDefaultAsync(c => c.Id == courseId && !EF.Property<bool>(c, "Deleted"));

            if (course == null)
            {
                return NotFound();
            }

            ViewBag.CourseId = courseId;
            ViewBag.CourseTitle = course.Name;
            return View(course.Lessons);
        }


        // GET: /Lesson/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var lesson = await _context.Lessons.FirstOrDefaultAsync(m => m.Id == id );

            if (lesson == null)
            {
                return NotFound();
            }

            return View(lesson);
        }




        // GET: /Lesson/Create?courseId=1
        public IActionResult Create(int courseId)
        {
            var course = _context.Courses.FirstOrDefault(c => c.Id == courseId);
            if (course == null)
            {
                return NotFound();
            }
            ViewBag.CourseId = courseId;
            var l = new Lesson();           
            return View(l);
        }

        // POST: /Module/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Lesson lesson)
        {   
            if (ModelState.IsValid)
            {
                lesson.Course=_context.Courses.FirstOrDefault(c=>c.Id == lesson.CourseId);
                _context.Lessons.Add(lesson);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { courseId = lesson.CourseId });
            }
            ViewBag.CourseId = lesson.CourseId;
            return View(lesson);
        }







        // GET: Module/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var module = await _context.Lessons
                .FirstOrDefaultAsync(m => m.Id == id && !EF.Property<bool>(m, "Deleted"));

            if (module == null)
            {
                return NotFound();
            }

            ViewBag.CourseId = module.CourseId;

            return View(module);
        }

        // POST: Module/Edit/5
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
                    var currLesson = await _context.Lessons.FindAsync(id);

                    if (currLesson == null)
                    {
                        return NotFound();
                    }

                    currLesson.Title = lesson.Title;

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModuleExists(lesson.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw; 
                    }
                }
                return RedirectToAction(nameof(Index), new { courseId = lesson.CourseId });

            }

            return View(lesson);
        }





        // GET: /Lesson/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var lesson = await _context.Lessons
                                       .Include(l => l.Course)
                                       .FirstOrDefaultAsync(l => l.Id == id && !EF.Property<bool>(l, "Deleted"));

            if (lesson == null)
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

            return RedirectToAction(nameof(Index), new { courseId = lesson.CourseId });
        }

        private bool ModuleExists(int id)
        {
            return _context.Lessons.Any(e => e.Id == id && !EF.Property<bool>(e, "Deleted"));
        }
    }
}
