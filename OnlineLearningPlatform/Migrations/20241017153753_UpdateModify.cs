using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "942b5984-25ef-445a-88e5-bd251ac302fe", "AQAAAAIAAYagAAAAEK2mUFBb3uhjiCANnpmkdO2jZk7EGbjIpB1hJNCq/UK4tjbWaoiH/7S14AwJGXR2bg==", "6466dd00-a5b5-4034-adef-716ebb6e6c08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86ce3b17-7efb-4fee-8fe3-c914f447d519", "AQAAAAIAAYagAAAAEMmFZgfD5xdeyzxz4cxwD40hxAbmQesFf6VSsc5YwEovctiKFdnU+4UZQ5ECU8fL+Q==", "880dc201-62c0-4897-b9c4-a04fccaf4eb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8fd62a7-5f2b-4fee-bf56-0ba9dbcf44de", "AQAAAAIAAYagAAAAEMhJreXbFt9OUsB2NC1THHvYStDaEWxm/TzTuZjTWHORQS47S0uf65zCI7Op/P85Gg==", "bd7a0bd5-da08-4d1c-90ad-07c5c4749025" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff06f391-7649-4321-960b-5f80571832ad", "AQAAAAIAAYagAAAAEKr8VgWzvveqEqyy1eBgqenQF5ZIpjJTKW1RvqW+QABmTnbJkE/9kZQQjBfXDuRK7w==", "eca0b4b5-a255-4840-b466-6489fc33b634" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2da69396-e456-48ec-a2f9-9477c4e2c027", "AQAAAAIAAYagAAAAEJ5PKYsT8kx/d+a0BE1C2liuhFgmZ7gg4PElh2cVPm9SuuXQVeRD1NEInoImeg8cbw==", "e31d7a0a-a7d8-40d7-a08e-77f258495cea" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48db0124-6289-4485-8f94-01d652d07822", "AQAAAAIAAYagAAAAEBBlSyFtrYgWd8AM6r6VAu/nBgGl4Ue+9wZFO2gnWxR69Im9Ot31wVW3qYVYIEwL5Q==", "54daa330-dbd7-4cbd-b974-63662764fae5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9cb8c1d-577c-4a65-a79c-4dc7ff23d073", "AQAAAAIAAYagAAAAEB4VkgmMDoB9ii84oNq9RUo0WvZKJ2po7uoWf/om6VzCyZyrQ12KUC+S3rjEFUww9g==", "46a04210-4a67-4725-9d16-65a044178f5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8c682eb-e89e-446f-90db-008d48dec796", "AQAAAAIAAYagAAAAEG9h3J9zYtPhBVugC11SgUbSbCt4YVhjNbVjIH6hLaPxtHVnDCU7k98fOpLdQLWFfw==", "072700ac-b727-4553-b01a-d8bba624f3c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96471ea5-b085-49d9-8081-d8ebd1c62607", "AQAAAAIAAYagAAAAEOeLUJPvJY4e14+nI+MxB+TQuPLwI6se4BtZlK8xSGPgGlxCk19zvCS+yTazgUHmbg==", "e4604360-0305-4cb0-b7e2-6de782a35cd6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71213b40-0121-4456-856b-fec5e831e9e9", "AQAAAAIAAYagAAAAEMX/0V785JCJtnT6V/oXmchzsgj2UXBRE++tWsFNLJdu2T9P0NpX3PaDSZA+bxmVYA==", "dd3cb142-585f-4828-acce-7e3c8a718bf6" });
        }
    }
}
