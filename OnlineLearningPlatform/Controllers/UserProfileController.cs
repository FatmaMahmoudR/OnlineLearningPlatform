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

        /// <summary>
        /// Retrieves the profile information of the currently logged-in user,
        /// including their username, email, and roles (Student or Instructor).
        /// If the user is not found, returns a NotFound result.
        /// </summary>
        /// <returns>A view with the user's profile data.</returns>
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
