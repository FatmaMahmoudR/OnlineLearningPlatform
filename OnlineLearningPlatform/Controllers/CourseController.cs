using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Models;

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

        // GET: /Course/
        public async Task<IActionResult> Index()
        {
            var courses = await _context.Courses.ToListAsync();
            return View(courses);
        }
    }
}
