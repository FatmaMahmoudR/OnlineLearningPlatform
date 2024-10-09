using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class AddDeletedColumnToCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a7d9edd-6fd7-41f7-8781-71fecfd06b8a", "AQAAAAIAAYagAAAAENft3Wn4+k2nnjFezqGhjbYDGMcJcRPrUr6mSTBdLXFJznlqngqhd5WPLMMTAnT5/A==", "d47616de-0cc1-473d-9a86-759a24297b77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e979e45-94aa-4288-b771-c8866bae7572", "AQAAAAIAAYagAAAAEFX0KdqpbcC63ZRZgjhzUaAI8TcAGD0xYnEVDq4IY0m+BwKSr4IDzdQID0yhPrOJoA==", "9287907f-518c-4804-bec4-4219768784ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0528fa1f-45f8-42f7-89f1-44ea03cea0b9", "AQAAAAIAAYagAAAAEH0O/PmTE9mzMC8stuUlQw6ixOHPfIpKIKOAaqegEAc5kPdXkgQn/bBPjwzgtmvg5A==", "989029e0-3eee-4bc2-84fc-15e392d859fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6622cb33-e0ac-49a4-9e1a-815d72b6b315", "AQAAAAIAAYagAAAAEDfJfNrdRO+AkRbZ9IFezPT4euFBu0y41fbM3HEWVguPKd55BkWmo2MoPpL41wWVnw==", "2d322617-f1c8-4f04-8a24-4413bb2dc68b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf7ab045-223f-4bd4-be4a-e0183e510696", "AQAAAAIAAYagAAAAEInEWXBMG5dj1xpT4ekFt0Rif+dx5+/DHtaRnFUGA72mFbi4YXzMWMiNGV8Ed7yIFg==", "ba6ac33f-5f17-4437-8ddc-9faa1c4105b7" });
        }
    }
}
