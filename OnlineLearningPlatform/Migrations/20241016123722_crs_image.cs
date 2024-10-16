using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class crs_image : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97d5842d-5a87-4f8e-8a41-0b6d8c143b22", "AQAAAAIAAYagAAAAEOdaQWwEsrpTXIBVU+i8JusR+vae+GBE5BgaKez3yqM1BwxZVYTpmDQnO51V8LRKKw==", "9fc9a728-69d6-4558-a2f6-e00e7eb5cf92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad34b9d7-f7bc-4bb4-85e0-da3185a5f6a5", "AQAAAAIAAYagAAAAEB4+8ESxVcJi0O67N+GHlQuMHIVkmggPw//JX1LGa+LkQM5wQmUBkJ6Jb967+Cxwuw==", "b16c0c2a-21d1-45a6-9bb1-60502dbf8ca6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57f5812c-fc64-44aa-9962-a3a791eca83b", "AQAAAAIAAYagAAAAEJ+7om0NxzeQT6UopzF7NXjYC9TOluItJtrGp62+TwDiVaRB2U43rTE98ufsM3WEDw==", "536218f0-fbf2-45c6-8fc4-1e5074a30347" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94433b14-d5f5-4175-84c6-6b87de9add82", "AQAAAAIAAYagAAAAEKQxNSw67KULou/cSMdCfueraawW8IwLl9DAHVYVH9Gwyjh+1dh4/f+3VQMPH+POIA==", "0158d13a-e84a-4791-a6d3-deb9d9257198" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14429bfa-8566-4c92-9d3b-47e7bc1e1c95", "AQAAAAIAAYagAAAAELeyctv2+MTIHeBPZbi2DxLWMMj0u3OkcLjzMef01UVOI9+g8rlZJgjFHK/Ii0yFvw==", "77240f34-9159-46f7-be4a-00476c2609e2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Courses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07af7fa1-7abf-4ea6-a08a-5fa06bf168ea", "AQAAAAIAAYagAAAAEBj06jEW0M8Y8+zb0Fp0h02YeOmZHIQ4471FSc7yxHougfOVWGBQ5WKcT8XWl1x6QQ==", "8bd9c650-d3a9-4b7c-a4a1-62f2f4872235" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be19538e-c3ab-4729-903f-e69f36eec77f", "AQAAAAIAAYagAAAAELch7sHF4UxMz/a+6cc5RX+6Fi9HYohAeeY/UOB4YpZXbFeQabHBmhu9plH43FTqnA==", "a2be0b89-94d7-483f-85fd-d3ff574d5086" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4df3df26-333c-4dc7-a7fe-291c8ceff33a", "AQAAAAIAAYagAAAAEGCEEynnOrVy5LJAHv6RAXwv5qUVUuqAg7juPc69Xy7Oaqhqm5YYI4f9iA5KJGEWnQ==", "e69cdb30-5eb0-4285-b0dd-363807f591b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "829cb554-c7b8-4d46-9bc4-008af223bb74", "AQAAAAIAAYagAAAAECz5pN1et0cZr8JvJ47OHfKezEHPbEoFiK+8zUmYo4DxGkoppmvQyebXC2qHct/OKg==", "cb820805-a7f4-4125-b0d1-3149604ecf46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c5f962b-a797-44f0-9654-50583458ac7c", "AQAAAAIAAYagAAAAENHq/f38ZL81OtOhMVu6ss+WIMcw9WVybEBORIYo9ss2ja/4vFUJU9/Y44CdQxf4/w==", "0437939b-d117-46e4-91da-0ba0455c682a" });
        }
    }
}
