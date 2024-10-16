using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class seedcrsImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97d5842d-5a87-4f8e-8a41-0b6d8c143b22", "AQAAAAIAAYagAAAAEOdaQWwEsrpTXIBVU+i8JusR+vae+GBE5BgaKez3yqM1BwxZVYTpmDQnO51V8LRKKw==", "9fc9a728-69d6-4558-a2f6-e00e7eb5cf92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad34b9d7-f7bc-4bb4-85e0-da3185a5f6a5", "AQAAAAIAAYagAAAAEB4+8ESxVcJi0O67N+GHlQuMHIVkmggPw//JX1LGa+LkQM5wQmUBkJ6Jb967+Cxwuw==", "b16c0c2a-21d1-45a6-9bb1-60502dbf8ca6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57f5812c-fc64-44aa-9962-a3a791eca83b", "AQAAAAIAAYagAAAAEJ+7om0NxzeQT6UopzF7NXjYC9TOluItJtrGp62+TwDiVaRB2U43rTE98ufsM3WEDw==", "536218f0-fbf2-45c6-8fc4-1e5074a30347" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94433b14-d5f5-4175-84c6-6b87de9add82", "AQAAAAIAAYagAAAAEKQxNSw67KULou/cSMdCfueraawW8IwLl9DAHVYVH9Gwyjh+1dh4/f+3VQMPH+POIA==", "0158d13a-e84a-4791-a6d3-deb9d9257198" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14429bfa-8566-4c92-9d3b-47e7bc1e1c95", "AQAAAAIAAYagAAAAELeyctv2+MTIHeBPZbi2DxLWMMj0u3OkcLjzMef01UVOI9+g8rlZJgjFHK/Ii0yFvw==", "77240f34-9159-46f7-be4a-00476c2609e2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: null);
        }
    }
}
