using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class lesson_iscompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContentFilePath",
                table: "Lessons",
                newName: "FilePath");

            migrationBuilder.AddColumn<bool>(
                name: "Iscompleted",
                table: "Lessons",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Iscompleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Iscompleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "Iscompleted",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Iscompleted",
                table: "Lessons");

            migrationBuilder.RenameColumn(
                name: "FilePath",
                table: "Lessons",
                newName: "ContentFilePath");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c285f53-ea24-4038-a59d-98593aeb3750", "AQAAAAIAAYagAAAAEFNDILiYqc/sj0YlR2nDeGMfHKqQLuaeVtp0iCejM+H15tqrHnyWkkhrlEbdzjVezw==", "9a880c4f-635f-4cd2-995e-0361bee80b64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b47b6603-ab7b-4e26-a88a-6aec172cdcc1", "AQAAAAIAAYagAAAAEK6a/PyUdTwXuOPhZ4TKuZ5NqYLZ8GjiqoS4n2/E5kYq4sqVCAekh9KzFSSc9wliVQ==", "21eb714a-6bb7-48c0-b41c-0345f467ae37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd84f5e9-a01b-4732-923f-70d6aface441", "AQAAAAIAAYagAAAAEMHd4CCuHVRN2L4mJYAsG3kNWTkXJIdBnR+U81oLaNMA2zKvEOGe9GJCtYb+K1YEkA==", "93c5f114-ca0b-45d8-93a5-0d0147699971" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3dfbb1d8-f889-4c93-ad7f-3c4a5d74df25", "AQAAAAIAAYagAAAAENZcIFuIGukYePURjvDjaUiKrBAPUWthwwKXPMq6grzofphE0y39WU9qaSkH8ECgfw==", "315b5ffb-a445-400d-a914-c8962e17fc4d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5c76dbd-f28e-4947-b062-1e6d16a435a8", "AQAAAAIAAYagAAAAEHCfM47PrkV2/cL/fkbjY8qfHTqCG6J9HkHf9waBE7jI2ACmjbXHoghmS0yIfrTICQ==", "56a530fc-f454-4050-a0b1-6acf0baa1ff2" });
        }
    }
}
