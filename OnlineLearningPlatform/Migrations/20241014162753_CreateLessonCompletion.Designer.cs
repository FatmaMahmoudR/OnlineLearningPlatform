﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineLearningPlatform.Models;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    [DbContext(typeof(context))]
    [Migration("20241014162753_CreateLessonCompletion")]
    partial class CreateLessonCompletion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "540fa4db-060f-4f1b-b60a-dd199bfe4f0b",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "540fa4db-060f-4f1b-b60a-dd199bfe4111",
                            Name = "Instructor",
                            NormalizedName = "INSTRUCTOR"
                        },
                        new
                        {
                            Id = "540fa4db-060f-4f1b-b60a-dd199bfe4001",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "62fe5285-fd68-4711-ae93-673787f4ac66",
                            RoleId = "540fa4db-060f-4f1b-b60a-dd199bfe4f0b"
                        },
                        new
                        {
                            UserId = "62fe5285-fd68-4711-ae93-673787f4a001",
                            RoleId = "540fa4db-060f-4f1b-b60a-dd199bfe4111"
                        },
                        new
                        {
                            UserId = "62fe5285-fd68-4711-ae93-673787f4a002",
                            RoleId = "540fa4db-060f-4f1b-b60a-dd199bfe4111"
                        },
                        new
                        {
                            UserId = "62fe5285-fd68-4711-ae93-673787f4a111",
                            RoleId = "540fa4db-060f-4f1b-b60a-dd199bfe4001"
                        },
                        new
                        {
                            UserId = "62fe5285-fd68-4711-ae93-673787f4a112",
                            RoleId = "540fa4db-060f-4f1b-b60a-dd199bfe4001"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("OnlineLearningPlatform.Entities.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AppUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Instructors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppUserId = "62fe5285-fd68-4711-ae93-673787f4a001"
                        },
                        new
                        {
                            Id = 2,
                            AppUserId = "62fe5285-fd68-4711-ae93-673787f4a002"
                        });
                });

            modelBuilder.Entity("OnlineLearningPlatform.Entities.Models.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Lessons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            FilePath = "https://youtu.be/qBTe6uHJS_Y?si=bnOHK8WHLtxAP13Y",
                            Title = "Introduction to ASP.NET Core"
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1,
                            FilePath = "https://youtu.be/jMFaAc3sa04?si=BQUUGmAtCxV2ye47",
                            Title = "Controllers and Views"
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 2,
                            FilePath = "https://youtu.be/SIQhe-yt3mA?si=R_G3denH8jmQMu_d",
                            Title = "Getting Started with EF Core"
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 2,
                            FilePath = "https://youtu.be/Mxm81T7waO8?si=BCU_ZxdJtD9IaM8A",
                            Title = "tmp2"
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 1,
                            FilePath = "https://youtu.be/yxQ9CSwc_uk?si=KdLELQAnBlpOZRb4",
                            Title = "ff"
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 1,
                            FilePath = "https://www.youtube.com/watch?v=SIQhe-yt3mA&t=1s",
                            Title = "nn"
                        });
                });

            modelBuilder.Entity("OnlineLearningPlatform.Entities.Models.LessonCompletion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EnrollmentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnrollmentId");

                    b.HasIndex("LessonId");

                    b.ToTable("LessonCompletions");
                });

            modelBuilder.Entity("OnlineLearningPlatform.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "62fe5285-fd68-4711-ae93-673787f4ac66",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "194d56a0-991d-4534-b993-9e237a441690",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEFFrdPl2NC4xlxzFUHY65nSfiujtuwAEgb55r+z/FdLIICKsUqNCo2sW9HT+Wfkpog==",
                            PhoneNumberConfirmed = false,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "096cd867-56d0-4a5d-94f0-93c0feed0aa5",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "62fe5285-fd68-4711-ae93-673787f4a001",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c9cf6842-c1e6-4fbd-a46c-4655b24050c5",
                            Email = "instructor1@user.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "INSTRUCTOR1@USER.COM",
                            NormalizedUserName = "INSTRUCTOR1",
                            PasswordHash = "AQAAAAIAAYagAAAAEPE8TfGcWiYbnY0KxMVltJo4fjcR3rnVp+FeZ4oQg9vM+Yyox+BMsl6TYQTc1zcGdg==",
                            PhoneNumberConfirmed = false,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "922701bd-593f-4c6e-8496-d779075d099f",
                            TwoFactorEnabled = false,
                            UserName = "instructor1"
                        },
                        new
                        {
                            Id = "62fe5285-fd68-4711-ae93-673787f4a002",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4a4c81b7-514c-4da3-ba39-7ad67e73e8bc",
                            Email = "instructor2@user.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "INSTRUCTOR2@USER.COM",
                            NormalizedUserName = "INSTRUCTOR2",
                            PasswordHash = "AQAAAAIAAYagAAAAEO2H4sB1PuXUrKpBv5TmXEKR+z983RwgRH7Dtf8fxFXiBqtbMnCuBa96gQ87OzaOHw==",
                            PhoneNumberConfirmed = false,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "df356651-1e71-4e91-b32a-675629a3a86b",
                            TwoFactorEnabled = false,
                            UserName = "instructor2"
                        },
                        new
                        {
                            Id = "62fe5285-fd68-4711-ae93-673787f4a111",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5ed0c474-e1fb-469f-aa7c-c8c07cd1c97d",
                            Email = "student1@user.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "STUDENT1@USER.COM",
                            NormalizedUserName = "STUDENT1",
                            PasswordHash = "AQAAAAIAAYagAAAAEPHAGUvg+Ke1+mwQ15PfpzEtjN6MnjfvvoOBEGpum2QMP3JzOG8E3ScWsNqtIc2y1A==",
                            PhoneNumberConfirmed = false,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "d0b713ef-ef53-4eb6-aff5-a2911e5e1b9b",
                            TwoFactorEnabled = false,
                            UserName = "student1"
                        },
                        new
                        {
                            Id = "62fe5285-fd68-4711-ae93-673787f4a112",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "12054b5d-07c9-4322-94fc-79881efbcd3c",
                            Email = "student2@user.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "STUDENT2@USER.COM",
                            NormalizedUserName = "STUDENT2",
                            PasswordHash = "AQAAAAIAAYagAAAAELb91pkj+f+y34h88s+WrEuiJq4SUlzI5rldtiZA7FdtLg9fHGFGnw2EIJjTcHdtfg==",
                            PhoneNumberConfirmed = false,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "fc9c2ae0-b0f1-431e-a644-628eeccc0291",
                            TwoFactorEnabled = false,
                            UserName = "student2"
                        });
                });

            modelBuilder.Entity("OnlineLearningPlatform.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DifficultyLevel")
                        .HasColumnType("int");

                    b.Property<int>("EnrollmentCount")
                        .HasColumnType("int");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Back-end",
                            Description = "Learn the basics of ASP.NET Core",
                            DifficultyLevel = 0,
                            EnrollmentCount = 0,
                            InstructorId = 1,
                            Name = "ASP.NET Core"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Back-end",
                            Description = "Master EF Core",
                            DifficultyLevel = 1,
                            EnrollmentCount = 0,
                            InstructorId = 2,
                            Name = "Entity Framework Core"
                        });
                });

            modelBuilder.Entity("OnlineLearningPlatform.Models.Enrollment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CompletionStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Progress")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AppUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppUserId = "62fe5285-fd68-4711-ae93-673787f4a111"
                        },
                        new
                        {
                            Id = 2,
                            AppUserId = "62fe5285-fd68-4711-ae93-673787f4a112"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("OnlineLearningPlatform.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OnlineLearningPlatform.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineLearningPlatform.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OnlineLearningPlatform.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineLearningPlatform.Entities.Models.Instructor", b =>
                {
                    b.HasOne("OnlineLearningPlatform.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("OnlineLearningPlatform.Entities.Models.Lesson", b =>
                {
                    b.HasOne("OnlineLearningPlatform.Models.Course", "Course")
                        .WithMany("Lessons")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("OnlineLearningPlatform.Entities.Models.LessonCompletion", b =>
                {
                    b.HasOne("OnlineLearningPlatform.Models.Enrollment", "Enrollment")
                        .WithMany("LessonCompletions")
                        .HasForeignKey("EnrollmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineLearningPlatform.Entities.Models.Lesson", "Lesson")
                        .WithMany()
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enrollment");

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("OnlineLearningPlatform.Models.Course", b =>
                {
                    b.HasOne("OnlineLearningPlatform.Entities.Models.Instructor", "Instructor")
                        .WithMany("TaughtCourses")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("OnlineLearningPlatform.Models.Enrollment", b =>
                {
                    b.HasOne("OnlineLearningPlatform.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Student", b =>
                {
                    b.HasOne("OnlineLearningPlatform.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("OnlineLearningPlatform.Entities.Models.Instructor", b =>
                {
                    b.Navigation("TaughtCourses");
                });

            modelBuilder.Entity("OnlineLearningPlatform.Models.Course", b =>
                {
                    b.Navigation("Enrollments");

                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("OnlineLearningPlatform.Models.Enrollment", b =>
                {
                    b.Navigation("LessonCompletions");
                });

            modelBuilder.Entity("Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
