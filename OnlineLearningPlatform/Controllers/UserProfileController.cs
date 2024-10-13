using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineLearningPlatform.Entities.ViewModels.UserProfile;
using OnlineLearningPlatform.Models;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Controllers
{
    public class UserProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public UserProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> UserProfile()
        {
            var user = await _userManager.GetUserAsync(User);    // Get the currently logged-in user

            if (user == null)
            {
                return NotFound(); 
            }

            var model = new UserProfileViewModel
            {
                Name = user.UserName, 
                Email = user.Email,
                IsStudent = await _userManager.IsInRoleAsync(user, "Student"),
                IsInstructor = await _userManager.IsInRoleAsync(user, "Instructor") 
            };

            return View(model);
        }
    }
}
