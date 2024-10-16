using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Entities.Models;
using OnlineLearningPlatform.Helpers;
using OnlineLearningPlatform.Migrations;
using System.Reflection;
using System.Reflection.Emit;

namespace OnlineLearningPlatform.Models
{
    public class context : IdentityDbContext<AppUser>
    {
        public context(DbContextOptions<context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            base.OnModelCreating(builder);

            //shadow prop for soft delete
            builder.Entity<Course>().Property<bool>("Deleted").IsRequired().HasDefaultValue(false);
            builder.Entity<Lesson>().Property<bool>("Deleted").IsRequired().HasDefaultValue(false);
           

            // global query filter -> delete course property
            builder.Entity<Course>().HasQueryFilter(c => !EF.Property<bool>(c, "Deleted"));
            builder.Entity<Lesson>().HasQueryFilter(m => !EF.Property<bool>(m, "Deleted"));

            //related tables
            builder.Entity<Enrollment>().HasQueryFilter(e => !EF.Property<bool>(e.Course, "Deleted"));

            // Configuring Enrollment with no cascade delete on Student and Course
            builder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentId)
                .OnDelete(DeleteBehavior.Restrict);  // No cascade delete

            builder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseId)
                .OnDelete(DeleteBehavior.Restrict);  // No cascade delete

            // Configuring Course and Instructor relationship with no cascade delete
            builder.Entity<Course>()
                .HasOne(c => c.Instructor)
                .WithMany(i => i.TaughtCourses)
                .HasForeignKey(c => c.InstructorId)
                .OnDelete(DeleteBehavior.Restrict);  // No cascade delete

            // Configuring Instructor and User relationship with no cascade delete
            builder.Entity<Instructor>()
                .HasOne(i => i.AppUser)
                .WithMany()  // or specify relation if needed
                .HasForeignKey(i => i.AppUserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Map CompletionStatus enum to string (nvarchar)
            builder.Entity<Enrollment>()
                .Property(e => e.CompletionStatus)
                .HasConversion<string>();

            // Seeding 'Administrator', 'Instructor', and 'Student' roles to AspNetRoles table
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "540fa4db-060f-4f1b-b60a-dd199bfe4f0b",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = "540fa4db-060f-4f1b-b60a-dd199bfe4111",
                    Name = "Instructor",
                    NormalizedName = "INSTRUCTOR"
                },
                new IdentityRole
                {
                    Id = "540fa4db-060f-4f1b-b60a-dd199bfe4001",
                    Name = "Student",
                    NormalizedName = "STUDENT"
                }
            );

            // A hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<AppUser>();

            // Seeding the Users to AspNetUsers table
            builder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = "62fe5285-fd68-4711-ae93-673787f4ac66", // Admin
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@admin.com",
                    NormalizedEmail = "ADMIN@ADMIN.COM",
                    PasswordHash = hasher.HashPassword(null, "123"),
                    EmailConfirmed = true
                },
                new AppUser
                {
                    Id = "62fe5285-fd68-4711-ae93-673787f4a001", // Instructor 1
                    UserName = "instructor1",
                    NormalizedUserName = "INSTRUCTOR1",
                    Email = "instructor1@user.com",
                    NormalizedEmail = "INSTRUCTOR1@USER.COM",
                    PasswordHash = hasher.HashPassword(null, "123"),
                    EmailConfirmed = true
                },
                new AppUser
                {
                    Id = "62fe5285-fd68-4711-ae93-673787f4a002", // Instructor 2
                    UserName = "instructor2",
                    NormalizedUserName = "INSTRUCTOR2",
                    Email = "instructor2@user.com",
                    NormalizedEmail = "INSTRUCTOR2@USER.COM",
                    PasswordHash = hasher.HashPassword(null, "123"),
                    EmailConfirmed = true
                },
                new AppUser
                {
                    Id = "62fe5285-fd68-4711-ae93-673787f4a111", // Student 1
                    UserName = "student1",
                    NormalizedUserName = "STUDENT1",
                    Email = "student1@user.com",
                    NormalizedEmail = "STUDENT1@USER.COM",
                    PasswordHash = hasher.HashPassword(null, "123"),
                    EmailConfirmed = true
                },
                new AppUser
                {
                    Id = "62fe5285-fd68-4711-ae93-673787f4a112", // Student 2
                    UserName = "student2",
                    NormalizedUserName = "STUDENT2",
                    Email = "student2@user.com",
                    NormalizedEmail = "STUDENT2@USER.COM",
                    PasswordHash = hasher.HashPassword(null, "123"),
                    EmailConfirmed = true
                }
            );

            // Seeding relations between our users and roles to AspNetUserRoles table
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "540fa4db-060f-4f1b-b60a-dd199bfe4f0b", // Admin role
                    UserId = "62fe5285-fd68-4711-ae93-673787f4ac66"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "540fa4db-060f-4f1b-b60a-dd199bfe4111", // Instructor role
                    UserId = "62fe5285-fd68-4711-ae93-673787f4a001"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "540fa4db-060f-4f1b-b60a-dd199bfe4111", // Instructor role
                    UserId = "62fe5285-fd68-4711-ae93-673787f4a002"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "540fa4db-060f-4f1b-b60a-dd199bfe4001", // Student role
                    UserId = "62fe5285-fd68-4711-ae93-673787f4a111"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "540fa4db-060f-4f1b-b60a-dd199bfe4001", // Student role
                    UserId = "62fe5285-fd68-4711-ae93-673787f4a112"
                }
            );

            // Seeding Instructors table
            builder.Entity<Instructor>().HasData(
                new Instructor
                {
                    Id = 1,
                    AppUserId = "62fe5285-fd68-4711-ae93-673787f4a001" // instructor1
                },
                new Instructor
                {
                    Id = 2,
                    AppUserId = "62fe5285-fd68-4711-ae93-673787f4a002" // instructor2
                }
            );

            // Seeding Students table
            builder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    AppUserId = "62fe5285-fd68-4711-ae93-673787f4a111" // student1
                },
                new Student
                {
                    Id = 2,
                    AppUserId = "62fe5285-fd68-4711-ae93-673787f4a112" // student2
                }
            );

            // Seeding Courses table
            builder.Entity<Course>().HasData(
                new Course
                {
                    Id = 1,
                    Name = "ASP.NET Core",
                    Description = "Learn the basics of ASP.NET Core",
                    Category = Category.Web,
                    DifficultyLevel = DifficultyLevel.Beginner,
                    EnrollmentCount = 0,
                    InstructorId = 1, // instructor1
                    Image = "\\Images\\CoursesImages\\031eb752-5090-48e5-8c91-8c6982d19f22_.net.PNG"
                },
                new Course
                {
                    Id = 2,
                    Name = "Entity Framework Core",
                    Description = "Master EF Core",
                    Category = Category.Web,
                    DifficultyLevel = DifficultyLevel.Intermediate,
                    EnrollmentCount = 0,
                    InstructorId = 2, // instructor2
                    Image = "\\Images\\CoursesImages\\124301a1-317a-4209-b6b7-e23c8acec6d0_ef.PNG"
                }
            );


            

			builder.Entity<Lesson>().HasData(
			new Lesson { Id = 1, CourseId = 1, Title = "Introduction to ASP.NET Core", FilePath = "https://youtu.be/qBTe6uHJS_Y?si=bnOHK8WHLtxAP13Y"},
			new Lesson { Id = 2, CourseId = 1, Title = "Controllers and Views", FilePath = "https://youtu.be/jMFaAc3sa04?si=BQUUGmAtCxV2ye47" },
			new Lesson { Id = 3, CourseId = 2, Title = "Getting Started with EF Core", FilePath = "https://youtu.be/SIQhe-yt3mA?si=R_G3denH8jmQMu_d" },
			new Lesson { Id = 4, CourseId = 2, Title = "tmp2", FilePath = "https://youtu.be/Mxm81T7waO8?si=BCU_ZxdJtD9IaM8A"},
			new Lesson { Id = 5, CourseId = 1, Title = "ff", FilePath = "https://youtu.be/yxQ9CSwc_uk?si=KdLELQAnBlpOZRb4"},
			new Lesson { Id = 6, CourseId = 1, Title = "nn", FilePath = "https://www.youtube.com/watch?v=SIQhe-yt3mA&t=1s" }
		);


		}

        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonCompletion> LessonCompletions { get; set; } 

    }
}
