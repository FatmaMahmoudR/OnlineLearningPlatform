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
        // GET: /Course/
        public async Task<IActionResult> Index()
        {
            var courses = await _context.Courses.ToListAsync();
            return View(courses);
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
                .FirstOrDefaultAsync(c => c.Id == id);

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Enroll(int courseId)
        {
            // Get the StudentId from claims (as GUID)
            var studentIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var studentId = GetStudentIdFromDatabase(studentIdClaim);


            // Check if the student is already enrolled in the course
            var existingEnrollment = await _context.Enrollments
                .FirstOrDefaultAsync(e => e.CourseId == courseId && e.StudentId == studentId);

            if (existingEnrollment != null)  // means true (he exist)
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
                    Progress = 0
                };

                _context.Enrollments.Add(enrollment);
                await _context.SaveChangesAsync();

                ViewBag.Message = "You have successfully enrolled in the course.";
            }
            return View(await _context.Courses.FindAsync(courseId)); 
        }

        // GET: /Course/Create
        public async Task<IActionResult> Create()
        {
            var instructors = await _context.Instructors.Include(i => i.AppUser).ToListAsync();
            ViewData["instructors"] = instructors;
            return View();
        }

        // POST: /Course/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
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
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses.Include(c => c.Instructor).FirstOrDefaultAsync(c => c.Id == id);

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
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: /Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.Id == id);
        }


        // Helper method to retrieve StudentId from the database
        private int GetStudentIdFromDatabase(string studentId)
        {
            var student = _context.Students.FirstOrDefault(s => s.AppUserId == studentId);
            return student?.Id ?? 0;
        }
    }
}
