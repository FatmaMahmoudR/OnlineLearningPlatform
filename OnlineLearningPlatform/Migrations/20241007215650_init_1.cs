using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class init_1 : Migration
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4f29bc35-3520-4d76-ac12-ccd0161a6dba", "instructor1@user.com", "INSTRUCTOR1@USER.COM", "INSTRUCTOR1", "AQAAAAIAAYagAAAAEPfUMq1cVVSA2vBS/BJojcqoqFmbPPQ34BXzjdHJFE4U8nI9yhx/920hI8Fi4P4nfg==", "60da451b-919f-44d1-9f85-fd5c4d4e5ea5", "instructor1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a9a5ec8c-700f-4754-a059-b8f607f6e880", "student1@user.com", "STUDENT1@USER.COM", "STUDENT1", "AQAAAAIAAYagAAAAEFh9w3M8Tqg49xPGL4yZljKwJfAygb4AxbWpfMSSFA+QuRTIsnxTZwqa2/+57CfGGA==", "748d75dd-9a23-4a9d-b7dc-c76b14b4e5ca", "student1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ce4a8a3-3ce5-4968-bf53-243070ba90ca", "AQAAAAIAAYagAAAAELKjxg0YT/GF3kSIU+dhhK2QjHylmg6QZlPmRD/w/lxeDZCnmFeJgiBembB4IfGOWQ==", "5bff36ba-3b28-4694-9b8a-e32de70b4964" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegistrationDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "62fe5285-fd68-4711-ae93-673787f4a002", 0, "7cb0f731-a402-4205-9a4f-427f14cb8eb9", "instructor2@user.com", true, false, null, "INSTRUCTOR2@USER.COM", "INSTRUCTOR2", "AQAAAAIAAYagAAAAEPRkEt5xOskTGW0EogRX8z7SMQOvWwSzux2YxQV+M1toyWwnpbmj5fTA75MdYmqGFw==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "40ecfc4b-a14e-45ee-bee6-5568b6e0881e", false, "instructor2" },
                    { "62fe5285-fd68-4711-ae93-673787f4a112", 0, "2f79d186-a911-4ea5-9489-c2f6308c4915", "student2@user.com", true, false, null, "STUDENT2@USER.COM", "STUDENT2", "AQAAAAIAAYagAAAAEEY9Z1jv3BxvcvS1IkxJcdICmaFQgu+YbW3aHlNV0i1LaYNlXHMbStKbNgSYCJH4YQ==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "30df1952-e5ff-4ea3-9237-0b54b23abd06", false, "student2" }
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
                values: new object[] { "c4d3f451-6268-47aa-bdfb-b36fee792ade", "user1@user.com", "USER1@USER.COM", "INSTRUCTOR", "AQAAAAIAAYagAAAAEPKoYIjbqHwS40YUtw631n55FGO9IZNXmWZdlL11SuKBZze9LtCtxkm5dwMQ9HoDjg==", "d0f78c92-b5be-41c1-aec9-c21684b997ec", "instructor" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "85b6264d-1a91-49eb-a266-d477a8317565", "user2@user.com", "USER2@USER.COM", "STUDENT", "AQAAAAIAAYagAAAAEDbtZTMxbKuuRjcOByIR/kP7zOUsdcKPvc6uVPLjZmVh+MQt1YSWfoC/0bJqV8Yx3A==", "452dccaa-223e-4826-9933-0b65be631c6e", "student" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66f89bc0-ff5a-47ae-abf9-1ab7d275179b", "AQAAAAIAAYagAAAAEPO81BDhk21P1dkYiD9UCBLdMDyKN4T0ywegCZVwbfKyKwK1o0v7zz7r/dGpjr3crQ==", "6f167335-98ce-4c4c-a712-266a7c99a7a4" });
        }
    }
}
