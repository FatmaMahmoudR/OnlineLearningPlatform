using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class init_15oct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62666e33-a484-4491-8537-d8967d52f76b", "AQAAAAIAAYagAAAAEDQgE4oeixwObCrVnme0TuNK7/ySsVH3Osv/h0eobrUOHltFw63jldF45n3NjvB8Nw==", "df16f253-6be0-46c9-bc4f-9c87f0796b30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "978ae2ea-5059-47b2-94bd-cfdf018991a0", "AQAAAAIAAYagAAAAENGZdcSfY9xgFe+Odj2ugYypRN4wsppG1VoOM/otpDGweTf3ZQrYCzrJVdFmTS10DA==", "89317844-2102-44ad-8688-9ac3f5beeb67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a978849-a53a-419b-8c85-09d2de97c575", "AQAAAAIAAYagAAAAEExHU6ZEDDHSpde6Kz5qSiRwFvwzdgvYUtO7ExGS9iLzk5G05sz9R+4MSlwJyh6DRg==", "920378c7-631f-48cb-b7d3-bc7f8cb2cd8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa679351-9489-4c54-b460-985fea65ef88", "AQAAAAIAAYagAAAAEJX13SKoY62mz+gsnvH1JSUZengQjLYy/+xXy2bFX6anb1+w6h28p1wZegQND/3UXw==", "f7edbbc8-d35a-4e76-8dab-c6ded169d047" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "039cc19a-c8dc-4954-8b68-0e46ff9f47f8", "AQAAAAIAAYagAAAAEAwWUBcK3uHYoN6xXjbimRxa/rAcCjIBOGR3SkajatYhA/YtHRvfd50pHx2jhhx7lA==", "5a3efafd-951c-4039-90e8-d823c439be17" });
        }
    }
}
