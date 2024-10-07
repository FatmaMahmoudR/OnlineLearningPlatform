using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class init_ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4d3f451-6268-47aa-bdfb-b36fee792ade", "AQAAAAIAAYagAAAAEPKoYIjbqHwS40YUtw631n55FGO9IZNXmWZdlL11SuKBZze9LtCtxkm5dwMQ9HoDjg==", "d0f78c92-b5be-41c1-aec9-c21684b997ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85b6264d-1a91-49eb-a266-d477a8317565", "AQAAAAIAAYagAAAAEDbtZTMxbKuuRjcOByIR/kP7zOUsdcKPvc6uVPLjZmVh+MQt1YSWfoC/0bJqV8Yx3A==", "452dccaa-223e-4826-9933-0b65be631c6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66f89bc0-ff5a-47ae-abf9-1ab7d275179b", "AQAAAAIAAYagAAAAEPO81BDhk21P1dkYiD9UCBLdMDyKN4T0ywegCZVwbfKyKwK1o0v7zz7r/dGpjr3crQ==", "6f167335-98ce-4c4c-a712-266a7c99a7a4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e35529c-0be9-4953-a59a-d4a395a4d6cc", "AQAAAAIAAYagAAAAEAoCYk6nMK7AXpQlwQ/f/Uyetr6JPW+uRjh9cBjDfYJFEJVAxrLFmcoU6t/Ht51CeA==", "b2999174-0073-425f-924d-ca951a1e10a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79463733-dac4-438a-95cf-4d8312a02dfb", "AQAAAAIAAYagAAAAEJLCRNznd9iO+K8DYZ7bQZNjUZvSpYaFXPemrwJ/gQ14wDRcsBbqpb12rjPPWCvh8g==", "1b496f04-38c7-4fff-aa09-ebafb7e4602d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c09df8f0-12b6-425b-9b8e-40abf9147d9b", "AQAAAAIAAYagAAAAEI5/90lKUSAONje445XIio0A4ySYyB6On94V0kdkVVR6GrN3zlbhKTerutbcSRIyFg==", "9f86f230-bdca-4ad8-8945-7d5948e5a194" });
        }
    }
}
