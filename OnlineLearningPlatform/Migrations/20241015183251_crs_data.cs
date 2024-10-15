using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class crs_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "243e31c6-271d-49d4-94c3-29cf27fda098", "AQAAAAIAAYagAAAAEAdCBW02o5lv1NsvPNBgisB2gYdAaWb3pbpCft65pTneBVvvur6bbQdsDI256KwU/w==", "909b30e8-bcf7-4edd-8396-929af9913824" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d95e8c3-b768-4d98-8ebc-c44ac0a4c7bb", "AQAAAAIAAYagAAAAELSbl3ARDb7ReX3eeUVtO6iIg2LYkKk+cdj6Dl6bMJddJXcdDDzmWhwJFRVsvz5OVA==", "5b14b16c-a1c0-459f-a74d-7ce6e9db7550" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a40b55be-d0dd-4227-acfc-30c9093aca5e", "AQAAAAIAAYagAAAAEKsyniLFxh3VL+WGTeqOknCFoSeqaMM5iqbIX19+PaWrpsxTv+OVYeXIXjYQ74Fz7A==", "96608bef-6e57-493c-8a93-3ce365d557f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7862fba9-76ae-4baf-96c2-fb3275d531d0", "AQAAAAIAAYagAAAAEPk24AGSGsWi+11u4uUsbBuLqvByvo3iOwvA1sKVRnaHaJDHhbVyPySZXYgOUVq54A==", "9fb8e6ce-d6d4-4928-9418-9fbbe80cbe66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f2576a6-b446-4ac4-8d55-21589f43f9f5", "AQAAAAIAAYagAAAAEGwuUHmiYxb5dYvjUZIkn7lxVp9XUu6aFY8kB0nQD1NfCT9szzXHNB3FCc3w3SHfpA==", "d407680c-7500-4c17-937f-e341f4a2fbde" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83cd5c72-91f3-4883-a591-9d754987dae7", "AQAAAAIAAYagAAAAEDHX0mb3cxJeyhuoGbiLT+7qDhLBOYlCywLFge3UZDCDca+FWSRBMlM9v3UDJnlH+g==", "6134d7de-f558-4461-9e21-5a9a05e515d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da907a4b-e196-472d-bfdb-a592d9d20e37", "AQAAAAIAAYagAAAAEOwdOqCrOKzmurOUwR03t3nPvC5Jes5xlpChPnQj60OhXEEiLObIDNlatmnVjzS2YA==", "c8b331d8-4066-4dfc-a625-d4f3e57872a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "955a0064-b747-48f9-b67e-263e92922760", "AQAAAAIAAYagAAAAEOILHby4u6Ne2SIiDyq+7LE/H4Zm2TIKctQ0CGYF6iP/EJK9f0mz+xmrdlFPP5QRLA==", "d6570f94-9a21-48e7-ba88-067987475ca3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fe57093-4a1d-4b54-b1b4-8503e717dcb6", "AQAAAAIAAYagAAAAEJxBmZCuk2tMc7nQWVw6eD5kFvSg+HpmzIInB5tQ/rbKJy3bV0qog0uZhs3xXyfDXg==", "1b6106d8-498b-4c31-9cb7-f684b7e06616" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eca215c6-9a93-46ab-8aaa-fcb8efe548df", "AQAAAAIAAYagAAAAEIMYrM0gBKdn3N5nNLGGdC5SmiP2NgudYD83Y2A578q28Vvca7CP7JkzrSdTG/7MxQ==", "446762e1-bfaa-4482-93d6-00c01ad98ff1" });
        }
    }
}
