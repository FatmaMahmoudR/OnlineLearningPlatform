using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Entities.ViewModels.Admin;
using OnlineLearningPlatform.Models;

namespace OnlineLearningPlatform.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<AppUser> _userManager;
        private IHttpContextAccessor _contextAccessor;
        public AdminController(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager, IHttpContextAccessor contextAccessor)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _contextAccessor = contextAccessor;
        }

        #region Roles
        /// <summary>
        /// Retrieves and displays all roles in the system.
        /// </summary>
        /// <returns>A view with a list of roles.</returns>
        public async Task<IActionResult> GetAllRoles()
        {
            var roles = await _roleManager.Roles.Select(r=> new RolesViewModel()
            {
                Id = r.Id,
                RoleName = r.Name
            }).ToListAsync();           
            return View(roles);
        }

        /// <summary>
        /// Displays the view for creating a new role.
        /// </summary>
        /// <returns>A view for creating a new role.</returns>
        public IActionResult NewRole()
        { 
            var role = new RolesViewModel() { Id = Guid.NewGuid().ToString() };
            return View(role);
        }

        /// <summary>
        /// Handles the submission of a new role, validates the model,
        /// and creates the role if valid.
        /// </summary>
        /// <param name="item">The role details to create.</param>
        /// <returns>Redirects to role list on success or returns errors.</returns>

        [HttpPost]
        public async Task<IActionResult> NewRole(RolesViewModel item)
        {
           
            if(ModelState.IsValid)
            {
                var role = new IdentityRole { Id = item.Id, Name = item.RoleName };
                var result = await _roleManager.CreateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("GetAllRoles");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(item);
        }
        #endregion

        #region Users

        /// <summary>
        /// Retrieves and displays all users along with their roles.
        /// </summary>
        /// <returns>A view with a list of users and their roles.</returns>
        public async Task<IActionResult> GetAllUsers()
        {
            // First, retrieve all users from the database
            var users = await _userManager.Users
                .Select(u => new UserViewModel
                {
                    Id = u.Id,
                    UserName = u.UserName,
                    Email = u.Email
                })
                .ToListAsync();

            // Then, fetch roles for each user asynchronously
            foreach (var user in users)
            {
                user.UserRoles = await _userManager.GetRolesAsync(await _userManager.FindByIdAsync(user.Id));
            }

            return View(users);
        }


        /// <summary>
        /// Displays the role management view for a specific user.
        /// </summary>
        /// <param name="userId">The ID of the user whose roles are being managed.</param>
        /// <returns>A view for managing the user's roles or redirects if user not found.</returns>
        public async Task<IActionResult> ManageRoles(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return RedirectToAction("GetAllUsers");
            }

            var roles = await _roleManager.Roles.ToListAsync();
            var model = new UserRolesViewModel()
            {
                UserId = user.Id,
                UserName = user.UserName,
                UserEmail = user.Email,
                UserRoles = roles.Select(r=> new SelectedRoles()
                {
                    RoleName = r.Name,
                    IsSelected = _userManager.IsInRoleAsync(user, r.Name).Result
                }).ToList()
            };
            
            return View(model);
        }

        // POST: /Admin/UpdateRole
        /// <summary>
        /// Updates the roles for a specific user based on the submitted model.
        /// </summary>
        /// <param name="model">The updated user role information.</param>
        /// <returns>Redirects to the user list after updating roles.</returns>
        [HttpPost]
        public async Task<IActionResult> UpdateRole(UserRolesViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            if (user == null)
            {
                return RedirectToAction("GetAllUsers");
            }
            var userRoles = await _userManager.GetRolesAsync(user);
            await _userManager.RemoveFromRolesAsync(user, userRoles);
            await _userManager.AddToRolesAsync(user, model.UserRoles.Where(r => r.IsSelected == true).Select(ur => ur.RoleName));
            return RedirectToAction("GetAllUsers");
        }

       
        #endregion
    }
}
