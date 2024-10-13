﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineLearningPlatform.Models;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    [DbContext(typeof(context))]
    partial class contextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<bool>("Iscompleted")
                        .HasColumnType("bit");

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
                            Iscompleted = false,
                            Title = "Introduction to ASP.NET Core"
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1,
                            FilePath = "https://youtu.be/jMFaAc3sa04?si=BQUUGmAtCxV2ye47",
                            Iscompleted = false,
                            Title = "Controllers and Views"
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 2,
                            FilePath = "https://youtu.be/SIQhe-yt3mA?si=R_G3denH8jmQMu_d",
                            Iscompleted = false,
                            Title = "Getting Started with EF Core"
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 2,
                            FilePath = "https://youtu.be/Mxm81T7waO8?si=BCU_ZxdJtD9IaM8A",
                            Iscompleted = false,
                            Title = "tmp2"
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 1,
                            FilePath = "https://youtu.be/yxQ9CSwc_uk?si=KdLELQAnBlpOZRb4",
                            Iscompleted = false,
                            Title = "ff"
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 1,
                            FilePath = "https://www.youtube.com/watch?v=SIQhe-yt3mA&t=1s",
                            Iscompleted = false,
                            Title = "nn"
                        });
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
                            ConcurrencyStamp = "f72a0530-cd31-474b-b9d1-7b096bea5411",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEFI1enfuWt2PBoxKqbkjbxmMd+W7pFT8TuPg7G6DNOpfU3E27hS4DGqptV+FimRB5g==",
                            PhoneNumberConfirmed = false,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "9de6c36e-e102-48e3-b889-f52cca4b8954",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "62fe5285-fd68-4711-ae93-673787f4a001",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1899d5b1-bedc-4560-ab77-bb8a1616830f",
                            Email = "instructor1@user.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "INSTRUCTOR1@USER.COM",
                            NormalizedUserName = "INSTRUCTOR1",
                            PasswordHash = "AQAAAAIAAYagAAAAEPdSnB0KHUhHxdurfD3/1eYzpcu8/KCkU0mvDtYCBUVHDXK+3fv71q3hLPVfL48KFA==",
                            PhoneNumberConfirmed = false,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "4d79d601-9d45-41ed-8a7f-4de55cb3f60c",
                            TwoFactorEnabled = false,
                            UserName = "instructor1"
                        },
                        new
                        {
                            Id = "62fe5285-fd68-4711-ae93-673787f4a002",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d2a72c77-b5a3-41b6-a4bd-9a4a01ef5ad7",
                            Email = "instructor2@user.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "INSTRUCTOR2@USER.COM",
                            NormalizedUserName = "INSTRUCTOR2",
                            PasswordHash = "AQAAAAIAAYagAAAAEGV2qCTJR9LHwcSo4DvdXoJ0P6qCuSDKpIX85TS9eNfT1KrE+rwtbHRwfCKD/76g8Q==",
                            PhoneNumberConfirmed = false,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "59eecaf6-e7d3-4616-94a2-3c076930c6f2",
                            TwoFactorEnabled = false,
                            UserName = "instructor2"
                        },
                        new
                        {
                            Id = "62fe5285-fd68-4711-ae93-673787f4a111",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "88141bad-61a3-491a-ace4-96aaabc6a71e",
                            Email = "student1@user.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "STUDENT1@USER.COM",
                            NormalizedUserName = "STUDENT1",
                            PasswordHash = "AQAAAAIAAYagAAAAECfqkJLFRB0ymdZKhLNO2aUqjkpY7b583pnZeLTvHfjxxq1wvLxEyhR/Ke0dBG/jcQ==",
                            PhoneNumberConfirmed = false,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "d5c2bd0b-50bc-488b-9387-de8d585aac3c",
                            TwoFactorEnabled = false,
                            UserName = "student1"
                        },
                        new
                        {
                            Id = "62fe5285-fd68-4711-ae93-673787f4a112",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "de45d646-fa27-4a93-9522-51d80e54d73b",
                            Email = "student2@user.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "STUDENT2@USER.COM",
                            NormalizedUserName = "STUDENT2",
                            PasswordHash = "AQAAAAIAAYagAAAAECFUjCSV3arByho7rb67T9jzozuD7t0+18RLW4Df7AQ4Za5HcjluoGkrrOKvQ7NdJw==",
                            PhoneNumberConfirmed = false,
                            RegistrationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "f5ce884f-77c1-45db-bf16-60440660658e",
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

            modelBuilder.Entity("Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
