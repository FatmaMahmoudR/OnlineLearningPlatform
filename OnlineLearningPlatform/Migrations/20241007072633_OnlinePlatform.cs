using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class OnlinePlatform : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a06739d-6fa1-4881-897c-fb7ae6d62987", "AQAAAAIAAYagAAAAEJDWmM6wukBK6H6ZMLW3zUlF7ZiUwHNeDW3UaDMV5MI7HrbIUHwW1g94iv8aHZMF3Q==", "f863a6f0-f68c-43d5-bce5-b1b8d066ee85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55485ad5-2b5d-4c59-9653-b7e50ea979fd", "AQAAAAIAAYagAAAAEAj3qtTWUwDnEBelhOgu0kiHq4akFH+PmvTIMO/awYw4Qkt8bjS0tf5ktYYqg4Qfyw==", "74a1cd66-379f-425b-a34d-ae44d5b55067" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35d0afd5-e929-41c5-ba58-48ae3b5a354e", "AQAAAAIAAYagAAAAECiU/l/YEde8eFzxRucruWEotVWpY+RZcYvFAamzpGyNKPlKd97rMtnFYLmFnY464A==", "5246dcf8-ede6-4514-9479-737b9e6813f6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbb35ebc-53f2-4eb7-abcb-0e49561fd8b4", "AQAAAAIAAYagAAAAELRWZdvePUUQbvgWA8WncEV84Mfu36rwOiHLC+dOLjcokpT2/uC3gbpgDjFBk/Y14g==", "de24a94e-f371-4beb-bf40-a513d842fb62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbf0527a-28cd-47d3-94ed-00a9c2ed822a", "AQAAAAIAAYagAAAAEPc+B2k58K5fKvf8qtq/NLlAce7ECEViJrlquSAT/bSqzaP4ql2Lbu/p7JBmaAcQyA==", "884fca6b-7875-4818-b204-9efa5fbf216d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48a73b80-5338-4602-ad73-c3594e8ba391", "AQAAAAIAAYagAAAAEPG7p3LevqQYQm9SG1oLT7MgRFzQq39bM76XXSsApYGYldKAtA8h9LpD4gt0vxpxIA==", "8601caa1-15ec-4626-a038-1a6ce36eede4" });
        }
    }
}
