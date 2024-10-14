using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class CreateLessonCompletions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ecf625c-938e-4fd7-a0f2-d68ac5a976a2", "AQAAAAIAAYagAAAAEP4upC/wvo1Vd0ovpfTlif9x/0pVXC00rI/PvMPy/9dU6hM3dxr0sey6Hvz7eKYOzQ==", "db181cfd-fc71-4382-b085-c767acf6b050" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c19420a4-b8e8-4f0b-a079-4e3826b68d74", "AQAAAAIAAYagAAAAEOLfktNEKbqOpMU6cxmz1qeuTfFvqt4I3OtGV0B2nBFRLFSoMlA+BO8tId1c+qZA7g==", "215ee501-78e7-4d44-ae8e-85ece0fa7808" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c5748aa-e5eb-4543-9d0f-43bcae2fa4ce", "AQAAAAIAAYagAAAAEJRshaDSe0TNQXUHVqPRPFw3nz/HGH+mYMm6gA9as1UuWt4sHuofsvcs9UIOislYag==", "6038823e-bfb8-4166-bf28-30bde8e7c6c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb8f16e1-dfb3-4959-b152-c4363ead4efd", "AQAAAAIAAYagAAAAEPpFbofOSutf3M+eYE/7KYbpax65Oppm4icH36hwr9B09y9WOuObwkp3/iYFxCxfGQ==", "54ae4e2c-fb93-4b20-97eb-4fb0f408ca51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cab74fee-2ce8-47bf-9e45-200d0a541239", "AQAAAAIAAYagAAAAEEuMVINm7NqyzNEo20jF2cK6E8UFGiSlVIqYstK1v0uCsOkhj1VSZwv6USnoi9omRA==", "73923f10-055a-4a15-828e-bff8cf810c61" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfe62004-7cfd-4382-84dd-f393d2e81d45", "AQAAAAIAAYagAAAAEAPvs8XaEAq2VXJZFYcoYmkYcDZXUDe6NRW6Mgv98UIGLWryhu6Ah7PN47OekNxpJw==", "215438ad-6f7f-4f95-9021-73aeac8ecea1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a423c28f-8367-41b4-be69-b6321f1a0ffb", "AQAAAAIAAYagAAAAEIlMg6Diy6sywORtuGQWpT2U3Jy6F60UkTlu2xjW7MlE+yeYO1XYATfm+309YUO71A==", "0cb69311-6d7a-426b-8321-5a14b09a567a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "322f9c60-51d4-400c-9b89-b4d7fb47c2c0", "AQAAAAIAAYagAAAAEApVpjPOgh/XaUEUtzWRBNmL0Ll5zqwSu/5M02McX69CLSFBJg2s27/YRTz+F+C26A==", "35d88824-2a46-45e7-8865-dd26b8b62c8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3daecf7-1ffb-4050-a5be-709e9603430f", "AQAAAAIAAYagAAAAECitYlY8chNUlfcT5GoVcZBaAU0MzsL8MELso3WM6wt+3Y7sqa4DPzoXeDHUWSla9g==", "af37472a-4146-47ff-b0a6-2c73c9935b11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62beb7c3-c593-468e-bc67-eee5218a0810", "AQAAAAIAAYagAAAAEIueUYkgqQnHBSNqP1GksUO5fuPh2vpLDg9PV3S9Q22Aw9dkBL1I67hBzcOg4XUeTA==", "4850d75d-89c4-489c-81bd-d1ce440d33ad" });
        }
    }
}
