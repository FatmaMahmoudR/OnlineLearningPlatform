using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class lessonModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Modules_ModuleId",
                table: "Lesson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lesson",
                table: "Lesson");

            migrationBuilder.RenameTable(
                name: "Lesson",
                newName: "Lessons");

            migrationBuilder.RenameIndex(
                name: "IX_Lesson_ModuleId",
                table: "Lessons",
                newName: "IX_Lessons_ModuleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lessons",
                table: "Lessons",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3da2ab5c-447e-4a08-bacf-2b083a9b6001", "AQAAAAIAAYagAAAAECO2iDRTCsX3tuTjhoZMuiFrnfzCHso1yGS1vB8dgBGFc1O1arAfeuF6RiMcydrkrw==", "4e9425cd-0f70-4bca-83f0-bde83c9b046c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "117c8cce-a857-4372-9aa4-5ad977d12bd4", "AQAAAAIAAYagAAAAEGn4+1L8+E182VwD4vWVeZwXcX/Dcm5JwjAwjLGJFtOkM9VPgCrbtHTD+u21R3XWfg==", "3e1fb3b2-1c21-467c-844b-e2ffd462209e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2aca36cd-b6d3-4947-b2b1-94279b36bbe3", "AQAAAAIAAYagAAAAEAteKkkuxAcrxacVB1JDqmbzr0I/TfpxLhByhH0vD8bwylgH620nX7D/VhrgGkrY9g==", "281d541a-2d9d-492e-829f-803d5fddc15e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29ee26c3-bd52-46e9-8c94-5a48acb29b9b", "AQAAAAIAAYagAAAAEDAJKlQLg82K19anshZTbKeTQlyEyBIuwqa7XPId7FIiBhH0R+K75fEyhNoHIFuqvA==", "b6fd8185-8769-4607-9325-b4325f43c9be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad80fcd4-ee71-4dff-a3b8-3e070043b424", "AQAAAAIAAYagAAAAEOU8mpclhr0B/qg8uornrleORlSlYzQuthRwJUS7UngwXYOVvMi+td4Bt6TTKltW2A==", "21b01559-a275-4bea-bfb9-b0bcc762457f" });

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Modules_ModuleId",
                table: "Lessons",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Modules_ModuleId",
                table: "Lessons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lessons",
                table: "Lessons");

            migrationBuilder.RenameTable(
                name: "Lessons",
                newName: "Lesson");

            migrationBuilder.RenameIndex(
                name: "IX_Lessons_ModuleId",
                table: "Lesson",
                newName: "IX_Lesson_ModuleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lesson",
                table: "Lesson",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54dffd41-3c8a-4525-b7c8-6efe1ab14915", "AQAAAAIAAYagAAAAEKZ8TMuatY1987e43IfKUiXFAFMEHdyllGVmMVp4n5rLI5bNjk44mvjXM46EO+nJkg==", "778145b0-5525-45f0-91e2-7047394c4aff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5613e7b4-b9a7-48a1-a417-1db9b9af6ad3", "AQAAAAIAAYagAAAAEBVBLRGtkS7tPtPD66vdDPXMMThm7hBNFa7kdmp0qv4XTrshDOvB8EVpQAdcOm1cIQ==", "091f40c7-2023-43d7-9176-c7acb211b4ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42e31caf-48ec-4fcd-ad2a-310a3ebf69de", "AQAAAAIAAYagAAAAEIQZTZad0K/EtsYffN4n7KpxBCuYQgBqrS526y/PFpsba8kq+k9WJZ+Ly3+woeGX4w==", "213db2d0-4d77-49a1-8d8b-259be3aa947a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a68f0e11-442b-42ee-ac23-ca9965440f6e", "AQAAAAIAAYagAAAAEGQFsVuir4ljoGkR+dwpk+FvnUKHnQPLKFxZlZdGMnGeQktMlIMrPoZKc5zNtfYiFQ==", "928eedc9-4df1-4ba0-ad51-7d18af1564d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fdb15d0-39f9-43a5-8e3a-f099fe6cbe78", "AQAAAAIAAYagAAAAEJZwkMluqf7uP56jQrtGK82SQM4muO+EDtgV5cyW92Aq1N7hgNN4CQuaDLvkQlE1mA==", "288c5858-9fc1-456e-805d-8f208f3fbc58" });

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Modules_ModuleId",
                table: "Lesson",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
