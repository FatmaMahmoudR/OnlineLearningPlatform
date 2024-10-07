using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class AddEnrollmentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e1a2a48-cf1f-4888-b994-e8241e2ff423", "AQAAAAIAAYagAAAAEKcmfNxvt5UPrJoO8bpiWhCmLOmlchH3D/00I3N7BiSeJo/vLc4NgwD77iCoFuoKhg==", "3f22f1cb-3cd1-4517-80af-44fac3a71514" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd52a6a5-d36b-438e-b937-590f8699c2b9", "AQAAAAIAAYagAAAAEDDepqV/0z062LK3gY9P3BcBtYLoCXzWk50FwwoByTho78TOTPGRGuGaLfRJfqsBwA==", "1ea82663-ff66-48cd-96b6-99d0a763ef4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40337c16-33de-4682-8654-68f3393566d7", "AQAAAAIAAYagAAAAEAZdN94bDvg3AUZxyscGYLjeaLPiL615y1++elqUfH105IvjDBNTHfUNVpycQrNLPg==", "c0eb3f7c-412e-4b99-8297-4056b9d5333f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a06739d-6fa1-4881-897c-fb7ae6d62987", "AQAAAAIAAYagAAAAEJDWmM6wukBK6H6ZMLW3zUlF7ZiUwHNeDW3UaDMV5MI7HrbIUHwW1g94iv8aHZMF3Q==", "f863a6f0-f68c-43d5-bce5-b1b8d066ee85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55485ad5-2b5d-4c59-9653-b7e50ea979fd", "AQAAAAIAAYagAAAAEAj3qtTWUwDnEBelhOgu0kiHq4akFH+PmvTIMO/awYw4Qkt8bjS0tf5ktYYqg4Qfyw==", "74a1cd66-379f-425b-a34d-ae44d5b55067" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35d0afd5-e929-41c5-ba58-48ae3b5a354e", "AQAAAAIAAYagAAAAECiU/l/YEde8eFzxRucruWEotVWpY+RZcYvFAamzpGyNKPlKd97rMtnFYLmFnY464A==", "5246dcf8-ede6-4514-9479-737b9e6813f6" });
        }
    }
}
