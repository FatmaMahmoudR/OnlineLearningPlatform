using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class CreateLessonCompletion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9cf6842-c1e6-4fbd-a46c-4655b24050c5", "AQAAAAIAAYagAAAAEPE8TfGcWiYbnY0KxMVltJo4fjcR3rnVp+FeZ4oQg9vM+Yyox+BMsl6TYQTc1zcGdg==", "922701bd-593f-4c6e-8496-d779075d099f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a4c81b7-514c-4da3-ba39-7ad67e73e8bc", "AQAAAAIAAYagAAAAEO2H4sB1PuXUrKpBv5TmXEKR+z983RwgRH7Dtf8fxFXiBqtbMnCuBa96gQ87OzaOHw==", "df356651-1e71-4e91-b32a-675629a3a86b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ed0c474-e1fb-469f-aa7c-c8c07cd1c97d", "AQAAAAIAAYagAAAAEPHAGUvg+Ke1+mwQ15PfpzEtjN6MnjfvvoOBEGpum2QMP3JzOG8E3ScWsNqtIc2y1A==", "d0b713ef-ef53-4eb6-aff5-a2911e5e1b9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12054b5d-07c9-4322-94fc-79881efbcd3c", "AQAAAAIAAYagAAAAELb91pkj+f+y34h88s+WrEuiJq4SUlzI5rldtiZA7FdtLg9fHGFGnw2EIJjTcHdtfg==", "fc9c2ae0-b0f1-431e-a644-628eeccc0291" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "194d56a0-991d-4534-b993-9e237a441690", "AQAAAAIAAYagAAAAEFFrdPl2NC4xlxzFUHY65nSfiujtuwAEgb55r+z/FdLIICKsUqNCo2sW9HT+Wfkpog==", "096cd867-56d0-4a5d-94f0-93c0feed0aa5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
