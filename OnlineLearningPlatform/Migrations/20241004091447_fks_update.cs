using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class fks_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Instructors_InstructorId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Students_StudentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_AspNetUsers_ApplicationUserId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_AspNetUsers_AppUserId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_AppUserId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_ApplicationUserId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Courses_StudentId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "EnrollmentStatus",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Certification",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "InstructorId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0db13228-a882-4a27-b250-4fad2768e9e7", "AQAAAAIAAYagAAAAEI2+PijOWoFo0leC1Kt9z0WNjv78RpU7RFFpC6YOGE+tlZBGamYMF4JfGduyiYuYHQ==", "f51892fd-375c-40bf-b2ad-f1650e872687" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21495c3e-c4d9-4486-9f9d-ec20bae06a22", "AQAAAAIAAYagAAAAEDt9Q+NGilBY0hHoXovNfxwSs1kZ0qltiBifP68VQCGdZCDVduU06+i3ZSJCq7ET3w==", "cbf07502-009f-4103-a204-5da92d8f67f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f88086bc-a409-461b-980a-cb09dd8c7b11", "AQAAAAIAAYagAAAAEIYPI8mJ/KwzzXpM6+Gyh5RLZwVbOQiZFvSAlnO0DqcornwwODJBCs4yAQJ/mIvsCg==", "d28e7412-1254-4165-b9a9-d243ba8e3c67" });

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Instructors_InstructorId",
                table: "Courses",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Instructors_InstructorId",
                table: "Courses");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Students",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EnrollmentStatus",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Instructors",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Certification",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "InstructorId",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29a98f81-d9d0-44fc-8c8a-e633e7f6c201", "AQAAAAIAAYagAAAAEHbeX8OuowTj9zf9UNRoDjztjY3mJOo1mNNqreBHOiG9xH4/ppHAHOarYZGJHh2btg==", "6f3beeb3-dab6-4cb5-86cc-7d7350ed9dc8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8695498-dd51-48cf-b93a-21687edbdf12", "AQAAAAIAAYagAAAAECi5gAHZTZGHRvatNdnaAjjDIT6r9YyV06b6O64UqyXB7XgWfXJl09D6+9fG8XBYkA==", "abd01c37-f503-40bc-b17a-8882c9f1da1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fe24294-15f3-4d5b-8b02-168d5ed5fa3d", "AQAAAAIAAYagAAAAEDv6QPUDdsLa0QNQYnWYRXpLL5l3supDGWxruKRhlF2vo7bgXi8PBF1J3vhaHf1UEg==", "fac97178-bee2-42b8-b8d7-3be94afa0a06" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_AppUserId",
                table: "Students",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_ApplicationUserId",
                table: "Instructors",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StudentId",
                table: "Courses",
                column: "StudentId");

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
                name: "FK_Instructors_AspNetUsers_ApplicationUserId",
                table: "Instructors",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AspNetUsers_AppUserId",
                table: "Students",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
