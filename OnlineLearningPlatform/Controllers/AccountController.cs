using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Entities.ViewModels.Account;
using OnlineLearningPlatform.Models;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.App.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly context _context;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, context context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newUser = new AppUser
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    EmailConfirmed = true,
                    PhoneNumber = model.PhoneNumber // Fixed missing comma
                };

                // Create the user
                var result = await _userManager.CreateAsync(newUser, model.Password);

                if (result.Succeeded)
                {
                    // Assign "Student" role
                    var roleResult = await _userManager.AddToRoleAsync(newUser, "Student");

                    if (!roleResult.Succeeded)
                    {
                        foreach (var error in roleResult.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                        return View(model);
                    }
                    // Automatically sign in
                    await _signInManager.SignInAsync(newUser, isPersistent: false);

                    // Create a new Student entry
                    var student = new Student
                    {
                        AppUserId = newUser.Id // FK reference to the AppUser
                    };

                    // Add the student to the DbContext and save changes
                    await _context.Students.AddAsync(student);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Login(string? ReturnUrl)
        {
            ViewData["ReturnUrl"] = ReturnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string? ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.UserName)
                    ?? await _userManager.FindByEmailAsync(model.UserName);

                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "User data incorrect");
                    return View(model);
                }

                var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    return string.IsNullOrEmpty(ReturnUrl) ? RedirectToAction("Index", "Home") : Redirect(ReturnUrl);
                }

                ModelState.AddModelError(string.Empty, "User data incorrect");
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        // GET: Account/UserProfile
        public async Task<IActionResult> UserProfile()
        {
            // Check if the user is authenticated
            if (!User.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Login", "Account"); // Redirect to the login page
            }

            // Get the current user's ID
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return RedirectToAction("Login", "Account"); // Redirect if the user is not found
            }

            // Create the ViewModel
            var userProfile = new UserProfileViewModel
            {
                Name = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                IsStudent = await _userManager.IsInRoleAsync(user, "Student"),
                IsInstructor = await _userManager.IsInRoleAsync(user, "Instructor")
            };

            return View(userProfile); // Return the View with the ViewModel
        }

        // GET: Account/Edit
        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            // Get the current user's ID
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            // Create the ViewModel
            var model = new UserProfileViewModel
            {
                Name = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };

            return View(model);
        }

        // POST: Account/Edit
        [HttpPost]
        public async Task<IActionResult> Edit(UserProfileViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Get the current user's ID
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            // Update user details
            user.UserName = model.Name;
            user.Email = model.Email;
            user.PhoneNumber = model.PhoneNumber;

            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }

            return RedirectToAction("UserProfile"); // Redirect to user profile after update
        }

        // Uncomment if you want to add access denied handling
        // public IActionResult AccessDenied()
        // {
        //     return View();
        // }
        // public IActionResult AccessDeniedNew()
        // {
        //     return View();
        // }
    }
}
