using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fe72e0a-58c6-4846-b7f3-8ce6348f49b1", "AQAAAAIAAYagAAAAEO3AL6HvJdTPIAx1lW0aAdQzRZ6Ihygh1aD2JhVSyX1uJd5h+VCMYa6hl69KNRO6NQ==", "80a38866-1d05-4eb7-899b-0ae06fd06ff4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a043613a-a6aa-4470-891f-9689e168b1a6", "AQAAAAIAAYagAAAAEGVjnRMNaGANY8oAY9LDrwJB8ggySn6Dzq7QZLMe9jw6qQ+wvP0Fr4+ctLf6/leoBA==", "505d075d-c133-4d31-a154-c0e60bb8ef96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c74feddc-bfb9-4a80-a93c-fd718dd3e2cb", "AQAAAAIAAYagAAAAEP9Kj+9irN8TcjjBoukpxMgPo7Q77Z0JTqQlm7RmaO60y3K/XUuOvo42EzsUY3EZoQ==", "11845292-27be-4c8d-b9c5-c7ea9b3ecae7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b689914-8437-4861-98b9-660e8785c1f8", "AQAAAAIAAYagAAAAEIL7bbW3lzscROJCasvvcSt65ZM5JyYRnizA+7TdDp/pnPXJ9nKTdt/Vv+wYDxPFfA==", "39a39250-374a-4c0d-a447-3f8c02f59ed8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e0b7199-c695-46c3-913c-58daded3403d", "AQAAAAIAAYagAAAAEPfTMsDfS+naD11thCb3MVXFC0QS9SrNJs/WZvwjk4Hyz/lgVLWeqm0Upwi+x5kFmQ==", "bc11af4b-8d1c-4491-bce1-ccdbeac38378" });
        }
    }
}
