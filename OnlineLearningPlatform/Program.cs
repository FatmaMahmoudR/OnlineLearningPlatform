using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.App.interfaces;
using OnlineLearningPlatform.App.Repositories;
using OnlineLearningPlatform.Models;

namespace OnlineLearningPlatform
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Add the DbContext (Ensure this matches your actual DbContext class)
            builder.Services.AddDbContext<context>(opt =>
                opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

            // Add Identity services
            builder.Services.AddIdentity<AppUser, IdentityRole>(opt =>
            {
                // Adjust password options as needed
                opt.Password.RequiredLength = 1;
                opt.Password.RequiredUniqueChars = 0;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireDigit = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
            })
            .AddEntityFrameworkStores<context>() // Ensure this matches your actual DbContext class
            .AddDefaultTokenProviders();

            // Cookie configuration for Identity
            builder.Services.ConfigureApplicationCookie(opt =>
            {
                opt.AccessDeniedPath = new PathString("/Account/AccessDeniedNew");
            });

            builder.Services.AddScoped<IUploudFile, UploadFile>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

                    app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "courseDetails",
                    pattern: "Course/Details/{id:int}",
                    defaults: new { controller = "Course", action = "Details" }
                );

                // Add route for UserProfile
                endpoints.MapControllerRoute(
                    name: "userProfile",
                    pattern: "UserProfile/UserProfile", // Adjust the pattern if needed
                    defaults: new { controller = "UserProfile", action = "UserProfile" }
                );

                // Define the default route pattern
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });


            app.Run();
        }
    }
}
