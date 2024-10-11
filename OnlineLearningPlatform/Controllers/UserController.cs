using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineLearningPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineLearningPlatform.App.Controllers;

public class UserController : Controller
{
    private readonly UserManager<AppUser> _userManager;
    private readonly context _context;
    
    public UserController(UserManager<AppUser> userManager, context context)
    {
        _userManager = userManager;
        _context = context;
    }
    // get all the users and their roles from the database
    // authorize only the admin to view the users
    [Authorize(Roles = "Admin")]
    public IActionResult Index()
    {
        var users = _userManager.Users.ToList();
        var userRoles = new List<string>();
        foreach (var user in users)
        { 
            var roles = _userManager.GetRolesAsync(user).Result;
            userRoles.Add(roles.FirstOrDefault() ?? throw new InvalidOperationException());
        }
        ViewBag.Roles = userRoles;
        return View(users);
    }
    
    // Soft delete the user
    // authorize only the admin to delete the user
    [Authorize(Roles = "Admin")]
    // GET: UserController/Delete/3
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var user = await _userManager.Users
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(m => Equals(m.Id, id));

        if (user == null)
        {
            return NotFound();
        }

        if (_context.Entry(user).Property<bool>("Deleted").CurrentValue)
        {
            return NotFound();
        }

        return View(user);
    }
    
    // Post: UserController/Delete/3
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var user = await _userManager.Users
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(m => Equals(m.Id, id));

        if (user == null)
        {
            return NotFound();
        }

        _context.Entry(user).Property<bool>("Deleted").CurrentValue = true;
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
}