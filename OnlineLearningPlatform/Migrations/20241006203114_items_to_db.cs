using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class items_to_db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51a12bde-3f36-497b-8722-ecaef002e8d9", "AQAAAAIAAYagAAAAEP9uDZJDjbpwjGQrBhqJlh5DpZKxumgPcta+bIgzYs6Rjh1uiV2OI+YYc7HuPrb8KA==", "8eda341e-775a-434d-bfc5-1f5800f09ca2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "140dc51b-2014-437b-b14e-43436c0332d2", "AQAAAAIAAYagAAAAEF/6qMLP0JsK2UmppMCCV4tEy16PygrYEMV2Av8OsIEe2f48HaaTQg9Tlmr9BALbcg==", "32c7c8d2-b2d8-465f-a446-8624bfb32302" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7acdd08-8e91-4273-81e9-088afa7be451", "AQAAAAIAAYagAAAAEFotZ6a1kwjVv08iUPG86JHaeu3nTn8KD5BCs/fpGuR0cgfNEQuLdJs1S24nxirSyw==", "65b2745a-1bc8-43e8-9a09-f14abeb934a2" });
        }
    }
}
