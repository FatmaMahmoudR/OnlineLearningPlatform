using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Entities.Models;
using OnlineLearningPlatform.Helpers;

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

            // Seeding 'Administrator' role to AspNetRoles table
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

            // Seeding the User to AspNetUsers table
            builder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = "62fe5285-fd68-4711-ae93-673787f4ac66", //PK
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@admin.com",
                    NormalizedEmail = "ADMIN@ADMIN.COM",
                    PasswordHash = hasher.HashPassword(null, "123"),
                    EmailConfirmed = true
                },
                new AppUser
                {
                    Id = "62fe5285-fd68-4711-ae93-673787f4a001", //PK
                    UserName = "instructor",
                    NormalizedUserName = "INSTRUCTOR",
                    Email = "user1@user.com",
                    NormalizedEmail = "USER1@USER.COM",
                    PasswordHash = hasher.HashPassword(null, "123"),
                    EmailConfirmed = true
                },
                new AppUser
                {
                    Id = "62fe5285-fd68-4711-ae93-673787f4a111", //PK
                    UserName = "student",
                    NormalizedUserName = "STUDENT",
                    Email = "user2@user.com",
                    NormalizedEmail = "USER2@USER.COM",
                    PasswordHash = hasher.HashPassword(null, "123"),
                    EmailConfirmed = true
                }
            );

            // Seeding the relation between our user and role to AspNetUserRoles table
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "540fa4db-060f-4f1b-b60a-dd199bfe4f0b", // admin role
                    UserId = "62fe5285-fd68-4711-ae93-673787f4ac66"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "540fa4db-060f-4f1b-b60a-dd199bfe4111", // instructor role
                    UserId = "62fe5285-fd68-4711-ae93-673787f4ac66"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "540fa4db-060f-4f1b-b60a-dd199bfe4001", // student role
                    UserId = "62fe5285-fd68-4711-ae93-673787f4ac66"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "540fa4db-060f-4f1b-b60a-dd199bfe4111", // instructor role
                    UserId = "62fe5285-fd68-4711-ae93-673787f4a001"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "540fa4db-060f-4f1b-b60a-dd199bfe4001", // student role
                    UserId = "62fe5285-fd68-4711-ae93-673787f4a111"
                }
            );
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}
