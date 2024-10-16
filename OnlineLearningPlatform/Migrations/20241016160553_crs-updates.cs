using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class crsupdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3855e13-1ebe-4715-baeb-8c5bd708f635", "AQAAAAIAAYagAAAAELqnzVzoCZtxUavp3baKsLhP9GQtU4srxvO7sCI0L6BVfTJq1sR2vfRdqCbolFszZA==", "1ce9741f-cd83-4d3a-922d-809304aa8783" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4410024-41b8-438d-99d7-a899698f762e", "AQAAAAIAAYagAAAAEBHYWE6z+WfKtM7Ar0Hl8HSlm8x7BdukVnOgOrtJIUlDQbHckI23Cet8mIS64vzujg==", "e86592db-ce9b-4bd2-b15a-1b973165fab6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c8927b9-49e5-41f6-b0bb-a3ab906337e2", "AQAAAAIAAYagAAAAEAVjEdytuhSLOcxj4xcnZFPsihUAiqApsreIlRjZ4w87iPoomUfLownduzxzxCUD1Q==", "6afdf0b5-212a-4f08-8896-7151e4d9fca7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a228ad2-315d-463f-81e8-0391827b8e1c", "AQAAAAIAAYagAAAAEK3+uWgefziu59lwWtKQhiFWEL5kUIjodXK5TU8mKx4DfPBZSFG+0vl5K9mKjh+W2g==", "03e4299a-750e-43da-b3a5-8a4d3ed07a64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa9d1f1c-aada-4218-b9b8-e894cc97a2f5", "AQAAAAIAAYagAAAAEDqKsw4CADYHq3OLIr0NO4bnqdpPI/ViiJbEA6G7m3uwHOYIZV98mDaQBhSfmjjd5w==", "6884b86a-62f7-482f-ac03-8b7a9e0d1787" });
        }
    }
}
