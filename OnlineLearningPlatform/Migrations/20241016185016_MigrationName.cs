using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class MigrationName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "653376a3-4c1e-4a4f-8347-782c71603b07", "AQAAAAIAAYagAAAAEP9IUgWVIijjypemg6T1Rwie5Uf1NfO5SHEudTNiSsmPVn+IlHZ0ql3dyFq+buCsCQ==", "59cc2184-3c41-4ecd-892b-326679d25f66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bc7be75-9b0f-4b9b-a15b-7380559f3f23", "AQAAAAIAAYagAAAAEC+xAcHm3RnRu6NDkKjqqS0BNRDwSlf56AfCmlajK14fwKMoQO4xgjx3LnwYxLlP6g==", "0cb6266e-e9b7-43cb-946a-85479a5c7fb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9f053a0-07b6-4edd-b3ac-18019ef31a6a", "AQAAAAIAAYagAAAAEJ0MtN0tP0eqyGLMOQG+pJSH9MT0VYTUUC2nsoo1hH2DpO/EtPiUG12/v1CJDQLyDg==", "650e6933-fca3-4345-af34-531a37bc1a3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6b08e7e-d69d-43d2-acd5-46cb6db607c5", "AQAAAAIAAYagAAAAEDEGvNvQ3gib0mVek1aMouZ3/W6mC9IfCREQSa6hhBskxnXSxtfqFYC0qc464/DuxQ==", "2b5482f2-1a75-4a47-a86f-00fb08a1e4d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8d94a84-28b6-4750-a791-4d35298ce264", "AQAAAAIAAYagAAAAEEhX4Gh7XY9LQ/y1ZTIfLmLp9wSv4ktxf5s6+Tv0eHRN5Fg+9uTBVp1HLT+C1CJhOA==", "016da5cd-90f0-4eda-8d09-1fa17e574b42" });
        }
    }
}
