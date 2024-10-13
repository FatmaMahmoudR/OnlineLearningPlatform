using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class init_LessonCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Iscompleted",
                table: "Lessons");

            migrationBuilder.CreateTable(
                name: "LessonCompletions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnrollmentId = table.Column<int>(type: "int", nullable: false),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonCompletions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LessonCompletions_Enrollments_EnrollmentId",
                        column: x => x.EnrollmentId,
                        principalTable: "Enrollments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonCompletions_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b47913bf-cd9c-44d6-871d-39f3fa89b41c", "AQAAAAIAAYagAAAAEJ3FidrlW4Qk/qe2/CIjCVQWZ6z0c46C4IcKF1/rQuK1pBcny27Hyqp08CT82SybMA==", "28bb2926-7085-46dc-b7a4-b1d2e9b0af9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c98a61c6-5d3c-494a-99b9-e4e96ce985d5", "AQAAAAIAAYagAAAAECRIi0ge7+VRj8hMZfzyL3eHISAraI9gwSJIkmUZ7WINePkdkJHW+mx7SAmGkPSdIQ==", "4af3a1a8-f8a3-4983-a8f0-9c73bfc57f4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c130eb72-222e-4661-b60d-e69ccbee0652", "AQAAAAIAAYagAAAAEDYrlH6S4uLYCDN6XTsIjWN6pwSOE3H2wjVKly6k9cuXbSDjuj6GV7uQRYXrK8E9wA==", "44fd95e7-4867-4481-ab0e-de66ee9d06f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33d0e753-6ba8-4dd5-ab8c-6eac75eee03a", "AQAAAAIAAYagAAAAEJi2z7tLxqongxZTC4m2K1SRrXKKCnC7i8ZX2lbTv35OLgG4kFf3ptI3hjrz2pkLsA==", "9b9a3a66-e2a8-43d1-972d-22a7582b4110" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbbc4f23-f650-4217-9e8b-630643a019c5", "AQAAAAIAAYagAAAAECUmh+eTHjts4f350qsOKcJ+GtldWMBF3KYVURdu9w1t3ZaMxDSw78xqJ9UvCB+HSA==", "52ef55ff-31c9-4b9d-8e78-619836d76c1b" });

            migrationBuilder.CreateIndex(
                name: "IX_LessonCompletions_EnrollmentId",
                table: "LessonCompletions",
                column: "EnrollmentId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonCompletions_LessonId",
                table: "LessonCompletions",
                column: "LessonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LessonCompletions");

            migrationBuilder.AddColumn<bool>(
                name: "Iscompleted",
                table: "Lessons",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1899d5b1-bedc-4560-ab77-bb8a1616830f", "AQAAAAIAAYagAAAAEPdSnB0KHUhHxdurfD3/1eYzpcu8/KCkU0mvDtYCBUVHDXK+3fv71q3hLPVfL48KFA==", "4d79d601-9d45-41ed-8a7f-4de55cb3f60c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2a72c77-b5a3-41b6-a4bd-9a4a01ef5ad7", "AQAAAAIAAYagAAAAEGV2qCTJR9LHwcSo4DvdXoJ0P6qCuSDKpIX85TS9eNfT1KrE+rwtbHRwfCKD/76g8Q==", "59eecaf6-e7d3-4616-94a2-3c076930c6f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88141bad-61a3-491a-ace4-96aaabc6a71e", "AQAAAAIAAYagAAAAECfqkJLFRB0ymdZKhLNO2aUqjkpY7b583pnZeLTvHfjxxq1wvLxEyhR/Ke0dBG/jcQ==", "d5c2bd0b-50bc-488b-9387-de8d585aac3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de45d646-fa27-4a93-9522-51d80e54d73b", "AQAAAAIAAYagAAAAECFUjCSV3arByho7rb67T9jzozuD7t0+18RLW4Df7AQ4Za5HcjluoGkrrOKvQ7NdJw==", "f5ce884f-77c1-45db-bf16-60440660658e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f72a0530-cd31-474b-b9d1-7b096bea5411", "AQAAAAIAAYagAAAAEFI1enfuWt2PBoxKqbkjbxmMd+W7pFT8TuPg7G6DNOpfU3E27hS4DGqptV+FimRB5g==", "9de6c36e-e102-48e3-b889-f52cca4b8954" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Iscompleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Iscompleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "Iscompleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "Iscompleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "Iscompleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "Iscompleted",
                value: false);
        }
    }
}
