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

            builder.Services.AddDbContext<context>(opt =>
                            opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")));


            builder.Services.AddIdentity<AppUser, IdentityRole>(
                opt =>
                {
                    opt.Password.RequiredLength = 4;
                    opt.Password.RequiredUniqueChars = 2;
                    opt.Password.RequireNonAlphanumeric = false;
                    opt.Password.RequireDigit = false;
                    opt.Password.RequireLowercase = false;
                    opt.Password.RequireUppercase = false;
                    
                }
                ).AddEntityFrameworkStores<context>().AddDefaultTokenProviders();

            builder.Services.ConfigureApplicationCookie(opt =>
            {
                opt.AccessDeniedPath = new PathString("/Account/AccessDeniedNew");
            });

            //builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            // Register other services
            builder.Services.AddScoped<IUploudFile, UploadFile>();
          

            var app = builder.Build();

            // Configure the HTTP request pipeline
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

                endpoints.MapControllerRoute(
                    name: "userProfile",
                    pattern: "UserProfile/UserProfile",
                    defaults: new { controller = "UserProfile", action = "UserProfile" }
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.Run();
        }
    }
}
