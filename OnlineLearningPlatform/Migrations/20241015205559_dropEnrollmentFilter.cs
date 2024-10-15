using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class dropEnrollmentFilter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43165df0-b0c8-4430-ba55-d9188c2e94b2", "AQAAAAIAAYagAAAAEMVPUYIXVoLmEJxoEZmJ6c+cDgO/fDCV0SZEj1SSllg7MgyFl6SBLQDQayDDasSjpQ==", "1878e836-604f-4b0a-8b04-ae184ff8507e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d828c3ee-cfb0-4cfa-8449-318ac1f1c791", "AQAAAAIAAYagAAAAEIu/4dK3jGbXShQGZewwM/ZBrCepqXqiUSAyCKxO9e6E2zpkdva5/u3bDl0gHZRhZw==", "4370b30f-a217-4e66-847e-d88e94554567" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "424659d5-a7c6-4475-8288-146be0b614da", "AQAAAAIAAYagAAAAEIqGd4EO+ayUdweRCFi3/vBREWTh1QiBId4qgdNFdWoqqUXLFTBwEFIDcrcP+Jp7VA==", "a0891dd1-31f3-43dd-a235-d2ac44247676" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d52dbf0-cf25-428c-8fb2-1c0f792cf39d", "AQAAAAIAAYagAAAAEDk1hD8BkCso+5Tz9M8RM9r+tXaapzGQ2KNj6i/wE5fuBxqSb+ZFkJyAOKAKFoazhQ==", "31c04e4c-35d6-421a-8fa0-7758b8a541b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "290e8e9b-6d87-49fc-8bac-65bce6def588", "AQAAAAIAAYagAAAAEBCvy7x08JlwjuBPTmfeh+31mKxMT2LQvOoHiSIIenIxW7V+ROQuFLXw6uocDib3Qw==", "14cd87a4-bade-4314-bc69-93ab2c9edda9" });
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
