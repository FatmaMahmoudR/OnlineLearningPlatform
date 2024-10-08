using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Entities.ViewModels.Account;
using OnlineLearningPlatform.Models;

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
                    EmailConfirmed = true
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
                var user =await _userManager.FindByNameAsync(model.UserName);
                if (user == null)
                {
                    user = await _userManager.FindByEmailAsync(model.UserName);
                    if(user == null)
                    {
                        ModelState.AddModelError(string.Empty, "User data incorrect");
                        return View(model);
                    }
                    
                }
                var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(ReturnUrl))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                   return Redirect(ReturnUrl);
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

        //public IActionResult AccessDenied()
        //{
        //    return View();
        //}
        //public IActionResult AccessDeniedNew()
        //{
        //    return View();
        //}
    }
}
