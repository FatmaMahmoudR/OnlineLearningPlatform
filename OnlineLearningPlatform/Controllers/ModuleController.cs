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
    public class ModuleController : Controller
    {
        private readonly context _context;

        public ModuleController(context context)
        {
            _context = context;
        }

        // GET: Module
        // GET: /Module/Index?courseId=1
        public async Task<IActionResult> Index(int courseId)
        {
            var course = await _context.Courses
                                       .Include(c => c.Modules)
                                       .FirstOrDefaultAsync(c => c.Id == courseId && !EF.Property<bool>(c, "Deleted"));

            if (course == null)
            {
                return NotFound();
            }

            ViewBag.CourseId = courseId;
            ViewBag.CourseTitle = course.Name;
            return View(course.Modules);
        }


        // GET: /Module/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var module = await _context.Modules
                                       .Include(m => m.Lessons) // Include related lessons
                                       .FirstOrDefaultAsync(m => m.Id == id );

            if (module == null)
            {
                return NotFound();
            }

            return View(module);
        }




        // GET: /Module/Create?courseId=1
        public IActionResult Create(int courseId)
        {
            var course = _context.Courses.FirstOrDefault(c => c.Id == courseId);
            if (course == null)
            {
                return NotFound();
            }
            ViewBag.CourseId = courseId;
            var m = new Module();           
            return View(m);
        }

        // POST: /Module/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Module module)
        {   
            if (ModelState.IsValid)
            { 
                module.Course=_context.Courses.FirstOrDefault(c=>c.Id== module.CourseId);
                _context.Modules.Add(module);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { courseId = module.CourseId });
            }
            ViewBag.CourseId = module.CourseId;
            return View(module);
        }







        // GET: Module/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var module = await _context.Modules
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
        public async Task<IActionResult> Edit(int id, Module module)
        {
            if (id != module.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var currModule = await _context.Modules.FindAsync(id);

                    if (currModule == null)
                    {
                        return NotFound();
                    }

                    currModule.Title = module.Title;

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModuleExists(module.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw; 
                    }
                }
                return RedirectToAction(nameof(Index), new { courseId = module.CourseId });

            }

            // If we got this far, something failed; redisplay the form
            return View(module);
        }







        // GET: /Module/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var module = await _context.Modules
                                       .Include(m => m.Course)
                                       .FirstOrDefaultAsync(m => m.Id == id && !EF.Property<bool>(m, "Deleted"));

            if (module == null)
            {
                return NotFound();
            }

            return View(module);
        }

        // POST: /Module/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var module = await _context.Modules.FindAsync(id);
            if (module != null)
            {
                // Soft delete using shadow property
                _context.Entry(module).Property("Deleted").CurrentValue = true;
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index), new { courseId = module.CourseId });
        }

        private bool ModuleExists(int id)
        {
            return _context.Modules.Any(e => e.Id == id && !EF.Property<bool>(e, "Deleted"));
        }
    }
}
