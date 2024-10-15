using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class dropEnrollmentFilter0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56a3a292-ea82-43ac-9960-ead3de82a7ac", "AQAAAAIAAYagAAAAEDn1fwLTOk7hRANlraUklZkrMug9x1S0Bid95ZR0p7/QJo1hkpLwW2i/W+n0+Pd40g==", "3034bb00-0838-4e58-9362-11970ef71045" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "976f807a-5d4b-42d2-9811-437d064ea8ce", "AQAAAAIAAYagAAAAEI/5XBOAoWpf1j9bJnR+NaY5xWdPHMxJrHEUk2Q2RDCr0IkMvVNKfGjAPbhxny1JXg==", "7679d8b7-5fd9-4b1f-b6f8-1d589cd2d297" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98f2655f-18d1-467b-a52f-767d7d67739a", "AQAAAAIAAYagAAAAEL76ejtzI7iKVbcNU2DXVf7sjG3QTdzBC5PNoFdtopD6U6+cliZ+voOgPgKabeMmeQ==", "69fa3d5c-776d-4550-9203-6d8427775500" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b1368db-8c33-4c1f-9d63-94cf0247a6b9", "AQAAAAIAAYagAAAAEMBC1C04LxvCRUAnoIybZjJAddIAMWPa+POgk6HJKI0ANSTgJCAYIrbDdhUNik78Gg==", "7fa8126a-6b65-4ec0-bab7-f066176a3562" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "427dfadb-5be2-4045-8682-60377a383891", "AQAAAAIAAYagAAAAEDecSX01no3plSAwN8rc3FGwq+fkENr+wpiUFABNPjbMs9M9uUwUOxKwgqgo9VJfRA==", "bfc6ecf7-d4a3-4fec-b9e7-82eb3129dc84" });
        }
    }
}
