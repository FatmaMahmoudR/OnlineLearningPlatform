using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class module : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modules_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lesson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentFilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lesson_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54dffd41-3c8a-4525-b7c8-6efe1ab14915", "AQAAAAIAAYagAAAAEKZ8TMuatY1987e43IfKUiXFAFMEHdyllGVmMVp4n5rLI5bNjk44mvjXM46EO+nJkg==", "778145b0-5525-45f0-91e2-7047394c4aff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5613e7b4-b9a7-48a1-a417-1db9b9af6ad3", "AQAAAAIAAYagAAAAEBVBLRGtkS7tPtPD66vdDPXMMThm7hBNFa7kdmp0qv4XTrshDOvB8EVpQAdcOm1cIQ==", "091f40c7-2023-43d7-9176-c7acb211b4ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42e31caf-48ec-4fcd-ad2a-310a3ebf69de", "AQAAAAIAAYagAAAAEIQZTZad0K/EtsYffN4n7KpxBCuYQgBqrS526y/PFpsba8kq+k9WJZ+Ly3+woeGX4w==", "213db2d0-4d77-49a1-8d8b-259be3aa947a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a68f0e11-442b-42ee-ac23-ca9965440f6e", "AQAAAAIAAYagAAAAEGQFsVuir4ljoGkR+dwpk+FvnUKHnQPLKFxZlZdGMnGeQktMlIMrPoZKc5zNtfYiFQ==", "928eedc9-4df1-4ba0-ad51-7d18af1564d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fdb15d0-39f9-43a5-8e3a-f099fe6cbe78", "AQAAAAIAAYagAAAAEJZwkMluqf7uP56jQrtGK82SQM4muO+EDtgV5cyW92Aq1N7hgNN4CQuaDLvkQlE1mA==", "288c5858-9fc1-456e-805d-8f208f3fbc58" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Back-end", "Learn the basics of ASP.NET Core", "ASP.NET Core" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Back-end", "Master EF Core", "Entity Framework Core" });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "CourseId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Introduction to ASP.NET Core" },
                    { 2, 1, "Controllers and Views" },
                    { 3, 2, "Getting Started with EF Core" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_ModuleId",
                table: "Lesson",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_CourseId",
                table: "Modules",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22cee08d-2d43-451e-a7e5-97f0a35285a9", "AQAAAAIAAYagAAAAENdgS6fYCTNyI2mpXA6lqPzvlYpEHt0ICMxlCZhed7r4NEtT3GvYQWO6EDGVS9KocQ==", "494a813d-6006-4f56-9031-60e52348dcaf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49e7e0e6-a91f-42c7-9345-4156a0a0a9ad", "AQAAAAIAAYagAAAAEJ+Ux0vEOTpMydz8icH1JmYuXZj6c9BqjSZ7hSfBkgai68njwtx5TEgQ9aGByyq51g==", "7f7d9d32-bb29-40ff-a0cc-87b766f67352" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd2e214f-7755-40f2-ae42-820015011c26", "AQAAAAIAAYagAAAAEDy6cbQiE3fDEXcfHvqqaLoxyV2wBJLq1FpLW5qUKKC3akTTc5wZEWD5zyD3N0Vgxw==", "3f71a67f-9176-4f51-a4e1-408b34f594ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14877c73-d876-4c76-a025-38007d7986ee", "AQAAAAIAAYagAAAAECoo9zDNq5CzD2Z4K4p5a/i8fGld/a9UGoYDy3GW6/uPSuEHPvZH+xPdH/gwtNdLUQ==", "3ba13794-92e2-4633-ba58-75c76b5e42db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1dea2b61-e87e-45f3-be5f-cd3608ee1a8e", "AQAAAAIAAYagAAAAEJAmusI66fUu4tYg2RVrNZ6MeRSUnNfWh2mVHklvwka+7axmY0GGZWqy/7TBU5l7vA==", "c52bef16-01b7-4981-889d-4c95282569d8" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Category 1", "Description for Course 1", "Course 1" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Name" },
                values: new object[] { "Category 2", "Description for Course 2", "Course 2" });
        }
    }
}
