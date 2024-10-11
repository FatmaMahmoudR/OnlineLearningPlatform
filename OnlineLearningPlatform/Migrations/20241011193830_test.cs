using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "040260a3-9402-445c-b640-b2f6f34efe88", "AQAAAAIAAYagAAAAEMKlU7pdiNQO7e3YzRy8dcUZMGJ04z703opBtn3LOSXGJxtPgkwe5n1fGDIcMYYYtQ==", "c6ce1927-f15d-4059-848a-04adcdb56e9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f6ba7cb-c722-4023-87f7-bbf149facaf1", "AQAAAAIAAYagAAAAEKlsynhBdgeDmytI2esM6/GKOwp95MucN+rW4KSvQdkgRvNLLPL/i8+wPxaEGRNQbQ==", "b4dda985-34bd-40b4-8c52-fb1bae049b21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8233e9f8-00d9-4dd8-af3f-585f3db86498", "AQAAAAIAAYagAAAAEEq9xKEvjmWh01ulWqNDcYWphI214jxbydKDFlg0niMFilxZ8Gnqa/IXYwHOGITVWg==", "f3bf3f39-aeda-4b94-9bb1-6066d0ec1629" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d99ca3e-055b-4895-99be-69736f612699", "AQAAAAIAAYagAAAAEI0ZRwp60Hf9SnuuyFoiHCXRV//OdqozpyPp4T07+W4VSuixRYETroH29ZN2TpP3/w==", "912ea6b6-29d5-4f73-b3af-a549ad729601" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de8da9b2-ba36-4c54-a73a-eda4dd90b06c", "AQAAAAIAAYagAAAAEIgBsq6r2N45GY+bPhYbRyLmOQyX+0HMjlZyxxILvVx9NEEUga3SmR9Fg+c8weGw2Q==", "bbf64327-b497-46be-b733-d0ac10f2a275" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "669974f6-c4c0-4c89-9016-a1251138d4c1", "AQAAAAIAAYagAAAAEN9MVHdLdscg3S6dMU0ThCpLyefceU7HKmTSIdCYmoVCMW6Gz1wHZ8vV7hlwFqIaCw==", "ebc8f654-87ca-4b1e-9aaa-3e098a75b7e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2a7e479-14b5-4c26-9485-142072a19a80", "AQAAAAIAAYagAAAAEH0ZuLdRFeH/lSR4hhPpQEk9NnK8z/MC6mcXFXSGsN9IFwDSNVRtRZKIfGE2khlAQQ==", "7bbfc425-8c81-41fb-bfc9-ae540d2b5da3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac12a7a0-6ae2-4849-9056-150448f3c8a8", "AQAAAAIAAYagAAAAEDA5qwyWrH0aXkWLIcZz6rkjpg0IR2IO5VvxBujv23HO8+8w3hk0oozh1jRuk6gzPQ==", "923e9a65-3af4-447b-b69b-a69b6df9170a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7654ef77-eb78-4110-9369-ec7d48b8c453", "AQAAAAIAAYagAAAAEFWMWc0ie3Q2aI/mjgqE2zwo34E7bZv0L35D98J4xszGP4aPuWByj3t/JDJ4Hew7Mg==", "f5fd9037-7f8d-4c58-ac67-9bfa44aa8ef7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "576a6908-7174-4c95-bf76-8f9a6d22433b", "AQAAAAIAAYagAAAAEDzOXGqjVpG+gsWtcFXDYFyhdKicB7V///czZqWUWhkbWJscf5cmVIsGtFNZr8ISBw==", "e943f3d4-98d9-4ccd-b67e-2e2a90163957" });
        }
    }
}
