using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class dropAppUserName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegistrationDate", "SecurityStamp" },
                values: new object[] { "51a12bde-3f36-497b-8722-ecaef002e8d9", "AQAAAAIAAYagAAAAEP9uDZJDjbpwjGQrBhqJlh5DpZKxumgPcta+bIgzYs6Rjh1uiV2OI+YYc7HuPrb8KA==", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8eda341e-775a-434d-bfc5-1f5800f09ca2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegistrationDate", "SecurityStamp" },
                values: new object[] { "140dc51b-2014-437b-b14e-43436c0332d2", "AQAAAAIAAYagAAAAEF/6qMLP0JsK2UmppMCCV4tEy16PygrYEMV2Av8OsIEe2f48HaaTQg9Tlmr9BALbcg==", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "32c7c8d2-b2d8-465f-a446-8624bfb32302" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegistrationDate", "SecurityStamp" },
                values: new object[] { "a7acdd08-8e91-4273-81e9-088afa7be451", "AQAAAAIAAYagAAAAEFotZ6a1kwjVv08iUPG86JHaeu3nTn8KD5BCs/fpGuR0cgfNEQuLdJs1S24nxirSyw==", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "65b2745a-1bc8-43e8-9a09-f14abeb934a2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "Name", "PasswordHash", "RegistrationDate", "SecurityStamp" },
                values: new object[] { "8f85fca6-b9ec-41ea-a3d9-8abe9d4dce21", "instructor 1", "AQAAAAIAAYagAAAAENCvfUIGMXmu4WrPfVoQwEBaU1XwZo25BPntnyQt11g1g+ErBQT7sGhZWnUZwCX+Lw==", new DateTime(2024, 10, 5, 23, 59, 30, 407, DateTimeKind.Local).AddTicks(9491), "08b4293c-93cf-4bb6-89aa-182009cd07a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "Name", "PasswordHash", "RegistrationDate", "SecurityStamp" },
                values: new object[] { "cb89536a-9d9c-472d-8b7c-95bdf8030062", "student 1", "AQAAAAIAAYagAAAAEGPMuHFxshBv4FNHlnD+M9mTZzeJGknnPgOeNRkl3BNvYWuOta+seitfJzRlCQhuDA==", new DateTime(2024, 10, 5, 23, 59, 30, 490, DateTimeKind.Local).AddTicks(5607), "a4f9edd8-a3d6-4554-a504-00c159cfc080" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "Name", "PasswordHash", "RegistrationDate", "SecurityStamp" },
                values: new object[] { "f056f707-f66f-4e25-80db-070e1121060c", "admin", "AQAAAAIAAYagAAAAEMWcwAtyJqSgPl0Y3SyATEdSf13PCex5/UfehnPUVO5GDVPJIiLGx/SXNlyzvMET6Q==", new DateTime(2024, 10, 5, 23, 59, 30, 305, DateTimeKind.Local).AddTicks(9693), "f32f0d33-f80e-40b7-8751-d71cd61d8fb6" });
        }
    }
}
