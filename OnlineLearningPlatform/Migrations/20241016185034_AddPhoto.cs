using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class AddPhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2bb2379-f0df-4b84-bd32-eda5cc185119", "AQAAAAIAAYagAAAAEN+SxkK4YfnJeJ0SAG5zbf+11+X0eDrdu3/fgVuC6NMZjQ8cRW7tMjiG6B7klAud4g==", "e4d667c8-aebc-43dc-8ff6-8da4182ea31f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96e6f66d-042e-40d6-859e-359f4a1f8d4a", "AQAAAAIAAYagAAAAEDITfOEbEQKuXDRxQn2K7aUwmbjkDuxgg4nWD9eOGcdAqx78HfYm2g2ZFd3z31Wi0g==", "7d12eee2-134a-4980-9651-d259a4f00700" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d87a043a-e0d9-4a14-8397-7746314f215b", "AQAAAAIAAYagAAAAEJTrvVw0qVniroSTmoXM9TsbAfPS77PBmSLaAS7SjR42FjndZ9hMcqP8BA+GMFSrkA==", "a7d98588-0876-453a-b8ee-6b2c17e9a63f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2733214c-61d7-4eb4-a28e-163e5e144d60", "AQAAAAIAAYagAAAAEBgGV3tcRDGKGNHRR1pOdFjKK2tXEYtkV6psnAzc4Tu62tcqECK5H32bGp2rsgs/Zw==", "bfcf3f70-bcad-49fb-9cc7-21d34b6cc562" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f8bf4f2-6f70-40ff-aeac-e207dbde0bbb", "AQAAAAIAAYagAAAAEIzYf30+xhDVTET7qNRPqhyIbkgUa3pD11XX4KXDoM3zWNqDoSQKdKvz24gHSVF6RQ==", "86086eb1-f002-433c-be25-09a228452be0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c1621aa-d458-47cd-a0cb-7d1a51ff2ac5", "AQAAAAIAAYagAAAAEF0okdMX7m1+XfqbCrBdD6SDnGTKnlcKoM5ES1D8GputuYWBmHwacUNdSfX6FC2Pfg==", "3eab017e-cc1f-45a1-bcbe-327665f3a89c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b7d88c1-eb97-4898-9649-f6ad1640b2c1", "AQAAAAIAAYagAAAAENEnQMtnHKgMwLQWlL4B+5I22eX1XCcVSjgoob0s9ZoloRUT8QslwGQBU/4qSN5ABg==", "f9367897-c61e-4a4c-93cc-be5682c97bd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ff70182-ec66-425f-ad09-90715720c263", "AQAAAAIAAYagAAAAEJnf9kM3kW6IYkJabcciJ6zWPokrhqiiW5WJCM/Nm5Tq/RGSzbq8VicZCnpGJ1XzOw==", "6f28045f-13d7-43bc-b18e-ed92de8d9531" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee7fdd3b-fe53-470a-8100-7ad5fe655a1e", "AQAAAAIAAYagAAAAEMKlnI3p+Fd5UST9tYCjhOyQA/TzYfSJq67CmCJQlHHzWjjtRz840dyTwFEZBaI+Zw==", "73db60f8-99d8-4b7e-83e7-61557145d54b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aae367f1-cc5b-4fb2-89ce-4621f7f9badf", "AQAAAAIAAYagAAAAEFqZ6E/cQJ9PARi/WJMWjumEeZF/Dv7s3YLRCeGhmTA+O5mUJq0o4qPmeYUxU48y3A==", "7ca1f8bf-d583-4fe2-884e-67fdcaf3c806" });
        }
    }
}
