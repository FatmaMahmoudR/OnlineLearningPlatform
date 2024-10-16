using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class seedcrsImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "\\Images\\CoursesImages\\031eb752-5090-48e5-8c91-8c6982d19f22_.net.PNG");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "\\Images\\CoursesImages\\124301a1-317a-4209-b6b7-e23c8acec6d0_ef.PNG");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cabcddc4-449b-4e22-8610-805e0c1fe505", "AQAAAAIAAYagAAAAECwscEc5W4s96lE0v1PSfu8s37FzkjSGhg0Ykj/vPxtoin2QS1L6f34un9c8Nk5Evg==", "ae308163-29e6-414f-a014-460667d9e35c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5d0c21c-c7ad-4995-9873-04b4f1faa609", "AQAAAAIAAYagAAAAEM3iMpM9rvIThw7dhIKLQ5pO3S9tNZv1iQSDpVk67A08lxzSDBOyoMY+odV4FQnF/w==", "794e2337-aec1-44e2-89c4-843f511f8ed4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "643176dc-61b9-40ad-a51b-15eb2a894868", "AQAAAAIAAYagAAAAEFjAoqGDINkF1UVJOz8jAaOym/6CptLYqD5Kg9d3xCkkrmz7npcVkI7t2BHmsMhGJw==", "698dcc49-8a51-4cca-a717-f9a87df1c8b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d227a428-2cfd-43a3-885f-2aaea29a7dc2", "AQAAAAIAAYagAAAAEFFajgLW+kpSpxfd90ZxEIIOPXIR4Rc4MwGeNHHgi9en+XSDfYayO55y9ub5InA4Fg==", "35d86ba9-621b-452d-bb75-9cdb1ee778bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28b0303b-0afe-464f-b518-27b696f3b7c5", "AQAAAAIAAYagAAAAEJ8MKRAiqaiRuKKPxKaS63XM8sgF8mPsQLLMn9gV+w5QhSabkRSd6yocR9qHlqIcfQ==", "f362c6c4-23e5-430b-8849-5a7c6ed6320a" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "031eb752-5090-48e5-8c91-8c6982d19f22_.net.PNG");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "124301a1-317a-4209-b6b7-e23c8acec6d0_ef.PNG");
        }
    }
}
