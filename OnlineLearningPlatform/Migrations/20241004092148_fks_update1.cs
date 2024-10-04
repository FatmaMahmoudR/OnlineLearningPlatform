using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class fks_update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Instructors_InstructorId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CourseId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentId",
                table: "Enrollments");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Students",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Instructors",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "974f56b9-cc4b-407d-957f-abc79d4ac851", "AQAAAAIAAYagAAAAEHpG8MtsLbPOtOiu2EZZiQhVgLx6Oh/wLRXHUnIRzsgOr8U+opz5Tho4Yj4j+mRp7g==", "dae8a866-f39a-4051-a27e-76fb11d06692" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "124aab33-8955-44f5-8944-865fbdf31793", "AQAAAAIAAYagAAAAEBm+J1wCzk5Ubbd9xtMi67vjv7KInXetEtCNVlYOLaS/TEa/2ReOlc0cAq3G5qxjLw==", "a78e8722-532c-46ca-b5eb-acce5fee7482" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ce653b9-7dd5-43eb-8eb9-718692a77ee9", "AQAAAAIAAYagAAAAEFTv5SKYBNta6mXxEpFrsK9LklDAY6wBxF6Lz4XBWaxR4qvZB0JtVpj/65yvhOZHYw==", "4490cae5-a4bc-4100-b145-342ab166fac0" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_AppUserId",
                table: "Students",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_AppUserId",
                table: "Instructors",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Instructors_InstructorId",
                table: "Courses",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_CourseId",
                table: "Enrollments",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentId",
                table: "Enrollments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_AspNetUsers_AppUserId",
                table: "Instructors",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AspNetUsers_AppUserId",
                table: "Students",
                column: "AppUserId",
                principalTable: "AspNetUsers",
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
                name: "FK_Enrollments_Courses_CourseId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_AspNetUsers_AppUserId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_AspNetUsers_AppUserId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_AppUserId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_AppUserId",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Instructors");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_CourseId",
                table: "Enrollments",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentId",
                table: "Enrollments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
