using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "540fa4db-060f-4f1b-b60a-dd199bfe4001", "62fe5285-fd68-4711-ae93-673787f4ac66" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "540fa4db-060f-4f1b-b60a-dd199bfe4111", "62fe5285-fd68-4711-ae93-673787f4ac66" });

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9a7d9edd-6fd7-41f7-8781-71fecfd06b8a", "instructor1@user.com", "INSTRUCTOR1@USER.COM", "INSTRUCTOR1", "AQAAAAIAAYagAAAAENft3Wn4+k2nnjFezqGhjbYDGMcJcRPrUr6mSTBdLXFJznlqngqhd5WPLMMTAnT5/A==", "d47616de-0cc1-473d-9a86-759a24297b77", "instructor1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0528fa1f-45f8-42f7-89f1-44ea03cea0b9", "student1@user.com", "STUDENT1@USER.COM", "STUDENT1", "AQAAAAIAAYagAAAAEH0O/PmTE9mzMC8stuUlQw6ixOHPfIpKIKOAaqegEAc5kPdXkgQn/bBPjwzgtmvg5A==", "989029e0-3eee-4bc2-84fc-15e392d859fa", "student1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf7ab045-223f-4bd4-be4a-e0183e510696", "AQAAAAIAAYagAAAAEInEWXBMG5dj1xpT4ekFt0Rif+dx5+/DHtaRnFUGA72mFbi4YXzMWMiNGV8Ed7yIFg==", "ba6ac33f-5f17-4437-8ddc-9faa1c4105b7" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegistrationDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "62fe5285-fd68-4711-ae93-673787f4a002", 0, "4e979e45-94aa-4288-b771-c8866bae7572", "instructor2@user.com", true, false, null, "INSTRUCTOR2@USER.COM", "INSTRUCTOR2", "AQAAAAIAAYagAAAAEFX0KdqpbcC63ZRZgjhzUaAI8TcAGD0xYnEVDq4IY0m+BwKSr4IDzdQID0yhPrOJoA==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9287907f-518c-4804-bec4-4219768784ea", false, "instructor2" },
                    { "62fe5285-fd68-4711-ae93-673787f4a112", 0, "6622cb33-e0ac-49a4-9e1a-815d72b6b315", "student2@user.com", true, false, null, "STUDENT2@USER.COM", "STUDENT2", "AQAAAAIAAYagAAAAEDfJfNrdRO+AkRbZ9IFezPT4euFBu0y41fbM3HEWVguPKd55BkWmo2MoPpL41wWVnw==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2d322617-f1c8-4f04-8a24-4413bb2dc68b", false, "student2" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "AppUserId" },
                values: new object[] { 1, "62fe5285-fd68-4711-ae93-673787f4a001" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "AppUserId" },
                values: new object[] { 1, "62fe5285-fd68-4711-ae93-673787f4a111" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "540fa4db-060f-4f1b-b60a-dd199bfe4111", "62fe5285-fd68-4711-ae93-673787f4a002" },
                    { "540fa4db-060f-4f1b-b60a-dd199bfe4001", "62fe5285-fd68-4711-ae93-673787f4a112" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Description", "DifficultyLevel", "EnrollmentCount", "InstructorId", "Name" },
                values: new object[] { 1, "Category 1", "Description for Course 1", 0, 0, 1, "Course 1" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "AppUserId" },
                values: new object[] { 2, "62fe5285-fd68-4711-ae93-673787f4a002" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "AppUserId" },
                values: new object[] { 2, "62fe5285-fd68-4711-ae93-673787f4a112" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "Description", "DifficultyLevel", "EnrollmentCount", "InstructorId", "Name" },
                values: new object[] { 2, "Category 2", "Description for Course 2", 1, 0, 2, "Course 2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "540fa4db-060f-4f1b-b60a-dd199bfe4111", "62fe5285-fd68-4711-ae93-673787f4a002" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "540fa4db-060f-4f1b-b60a-dd199bfe4001", "62fe5285-fd68-4711-ae93-673787f4a112" });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112");

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Courses");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "540fa4db-060f-4f1b-b60a-dd199bfe4001", "62fe5285-fd68-4711-ae93-673787f4ac66" },
                    { "540fa4db-060f-4f1b-b60a-dd199bfe4111", "62fe5285-fd68-4711-ae93-673787f4ac66" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4e35529c-0be9-4953-a59a-d4a395a4d6cc", "user1@user.com", "USER1@USER.COM", "INSTRUCTOR", "AQAAAAIAAYagAAAAEAoCYk6nMK7AXpQlwQ/f/Uyetr6JPW+uRjh9cBjDfYJFEJVAxrLFmcoU6t/Ht51CeA==", "b2999174-0073-425f-924d-ca951a1e10a2", "instructor" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "79463733-dac4-438a-95cf-4d8312a02dfb", "user2@user.com", "USER2@USER.COM", "STUDENT", "AQAAAAIAAYagAAAAEJLCRNznd9iO+K8DYZ7bQZNjUZvSpYaFXPemrwJ/gQ14wDRcsBbqpb12rjPPWCvh8g==", "1b496f04-38c7-4fff-aa09-ebafb7e4602d", "student" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c09df8f0-12b6-425b-9b8e-40abf9147d9b", "AQAAAAIAAYagAAAAEI5/90lKUSAONje445XIio0A4ySYyB6On94V0kdkVVR6GrN3zlbhKTerutbcSRIyFg==", "9f86f230-bdca-4ad8-8945-7d5948e5a194" });
        }
    }
}
