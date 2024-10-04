using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class modelupdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Users_UserId",
                table: "Enrollments");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Enrollments",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_UserId",
                table: "Enrollments",
                newName: "IX_Enrollments_StudentId");

            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Certification = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructors_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EnrollmentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegistrationDate", "SecurityStamp" },
                values: new object[] { "29a98f81-d9d0-44fc-8c8a-e633e7f6c201", "AQAAAAIAAYagAAAAEHbeX8OuowTj9zf9UNRoDjztjY3mJOo1mNNqreBHOiG9xH4/ppHAHOarYZGJHh2btg==", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6f3beeb3-dab6-4cb5-86cc-7d7350ed9dc8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegistrationDate", "SecurityStamp" },
                values: new object[] { "c8695498-dd51-48cf-b93a-21687edbdf12", "AQAAAAIAAYagAAAAECi5gAHZTZGHRvatNdnaAjjDIT6r9YyV06b6O64UqyXB7XgWfXJl09D6+9fG8XBYkA==", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "abd01c37-f503-40bc-b17a-8882c9f1da1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegistrationDate", "SecurityStamp" },
                values: new object[] { "6fe24294-15f3-4d5b-8b02-168d5ed5fa3d", "AQAAAAIAAYagAAAAEDv6QPUDdsLa0QNQYnWYRXpLL5l3supDGWxruKRhlF2vo7bgXi8PBF1J3vhaHf1UEg==", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fac97178-bee2-42b8-b8d7-3be94afa0a06" });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_InstructorId",
                table: "Courses",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StudentId",
                table: "Courses",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_ApplicationUserId",
                table: "Instructors",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_AppUserId",
                table: "Students",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Instructors_InstructorId",
                table: "Courses",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Students_StudentId",
                table: "Courses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentId",
                table: "Enrollments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Instructors_InstructorId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Students_StudentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentId",
                table: "Enrollments");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Courses_InstructorId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_StudentId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "RegistrationDate",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Enrollments",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_StudentId",
                table: "Enrollments",
                newName: "IX_Enrollments_UserId");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10a04e85-236e-451f-b73a-7324a240fda8", "AQAAAAIAAYagAAAAENty6+3R2TWfphbwSWSZk0lHMD//Y8zRCjX1HtdNT3QhZBjX8uOh0IJl4CMiD6du3g==", "67cbba74-0634-4360-90d5-cd3f719eb418" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d99f4e8-36dd-47f6-b3e7-0364bd52ffba", "AQAAAAIAAYagAAAAEH7Ghp+d/KM6dK16C3gzK+U5RzUerBDtWw2cDHVxlqNBjOi9014VylJ064geijGtvQ==", "dfa8dc80-f8f0-47c9-be6e-3a9c08370e62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa2e63fc-09e0-4fd7-9a0b-968d82486f20", "AQAAAAIAAYagAAAAEBzuq5//H60KvRKFpsBsQIOQgKkO//7D/WiutreVd2WQwNuVRYc1qd8OzM4UWQJ0yg==", "df8d6b59-2f22-44eb-9564-d3ca508adca3" });

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Users_UserId",
                table: "Enrollments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
