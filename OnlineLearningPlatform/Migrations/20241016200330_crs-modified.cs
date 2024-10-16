using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class crsmodified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Modified",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Modified",
                value: false);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Modified",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Modified",
                table: "Courses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "653376a3-4c1e-4a4f-8347-782c71603b07", "AQAAAAIAAYagAAAAEP9IUgWVIijjypemg6T1Rwie5Uf1NfO5SHEudTNiSsmPVn+IlHZ0ql3dyFq+buCsCQ==", "59cc2184-3c41-4ecd-892b-326679d25f66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bc7be75-9b0f-4b9b-a15b-7380559f3f23", "AQAAAAIAAYagAAAAEC+xAcHm3RnRu6NDkKjqqS0BNRDwSlf56AfCmlajK14fwKMoQO4xgjx3LnwYxLlP6g==", "0cb6266e-e9b7-43cb-946a-85479a5c7fb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9f053a0-07b6-4edd-b3ac-18019ef31a6a", "AQAAAAIAAYagAAAAEJ0MtN0tP0eqyGLMOQG+pJSH9MT0VYTUUC2nsoo1hH2DpO/EtPiUG12/v1CJDQLyDg==", "650e6933-fca3-4345-af34-531a37bc1a3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6b08e7e-d69d-43d2-acd5-46cb6db607c5", "AQAAAAIAAYagAAAAEDEGvNvQ3gib0mVek1aMouZ3/W6mC9IfCREQSa6hhBskxnXSxtfqFYC0qc464/DuxQ==", "2b5482f2-1a75-4a47-a86f-00fb08a1e4d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8d94a84-28b6-4750-a791-4d35298ce264", "AQAAAAIAAYagAAAAEEhX4Gh7XY9LQ/y1ZTIfLmLp9wSv4ktxf5s6+Tv0eHRN5Fg+9uTBVp1HLT+C1CJhOA==", "016da5cd-90f0-4eda-8d09-1fa17e574b42" });
        }
    }
}
