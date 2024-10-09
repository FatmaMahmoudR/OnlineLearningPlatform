using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24e633c4-a547-42c3-9158-682bbacbbfa4", "AQAAAAIAAYagAAAAEFPXQNV8GyQFLgEBTPOuTWhfx9nxz6zHZcCc1g04QpdQxRqeSLJaZA9WNxVQ9aA91Q==", "c00eecee-efea-4b70-b3bb-a484e9cc3c06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cec11a8-ce86-4bc0-af8d-109ac5fd288e", "AQAAAAIAAYagAAAAEPeAK0/nUCp4FKQnUdiEr0PbSUl3XXwMEY4mUZu5ugy42mNhesI3A8aei99KAxczTA==", "fce49183-a3cc-496a-8177-6462ad6570ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1056a795-aad1-4235-bd43-fe134ebd8e6e", "AQAAAAIAAYagAAAAEA+7woLQbX9qaDpX+uCf4a6Slpqs3jliBU1xpZyUc69t/qduL15o0AAQuKRIgNuq8w==", "fdb13931-4941-409f-a2f2-b59ca89ece98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f39b2ee-7309-490e-8fb2-65eaf4a8d4d3", "AQAAAAIAAYagAAAAEKEHrCM+8Q3JZsUyC1ejOPU7NMDHutZ8gdYG9SpfmZlbXX88jTNtI1SxrmKFgX/QUQ==", "c2663eb2-acb8-4347-93ea-8b2a38fd127e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c6d3396-7b80-4af5-b89f-ce1804524e97", "AQAAAAIAAYagAAAAEKk/2QPb5NbfBVNwzoib7PSzJiUpI2O0ULcKHG/nmy/bXFAznBMWYGoI/AmPTfpcWA==", "31e88f8d-1cd9-4f12-b1eb-476e95b75f24" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5625080d-4026-4314-8c37-29437edecac4", "AQAAAAIAAYagAAAAENLAqZzkCYcCxtBKE4nPrV2d4Ubf866YGIP9Vt6moNh6kLPJ4fHNjcGEIIibVOPKYw==", "df5bc4ef-9426-4395-a873-4a5bb20eab56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23bc377a-016b-4d71-b901-9b2b2faef8a0", "AQAAAAIAAYagAAAAEM4ImN4bAQyhTpwLGPSO2jT2qHneQtOWgzqvUUcVnGhGdTSyHhOOxC24TfuEIuDlhQ==", "ce92cdc1-ab84-4e7e-ba8f-349041b7c498" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88dc1c87-eed5-4c77-a680-c2a80fa2e668", "AQAAAAIAAYagAAAAEPtVjUR3Z/bAhLFp16iwcLILKI/7OEzpClzkzUncLiXi6kbb4+EIzDJwwJnnlq+oyQ==", "0d252954-7912-4871-a555-bde3bb07f88f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0aa05e28-4308-4498-8bd9-07e5642c58f0", "AQAAAAIAAYagAAAAEP6vIm7NliuHbqJAno/moU6obd0tgzOqdFlBXQvfJL5K2hSj9qFRvyBdroYlEAhkvQ==", "5a9d8b17-818c-4917-a12e-2b81dcf55991" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47de6293-8212-4570-9b9c-e17f0ddfeec4", "AQAAAAIAAYagAAAAEO9l6UAOAySyehU6gTNXmsEvAY6h7fieM7iwkYT3RrQFXxje1kQWA6XZaNnKSjGtPw==", "df0b27ea-c693-4086-975a-eac31460b765" });
        }
    }
}
