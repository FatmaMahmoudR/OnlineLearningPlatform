using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class dropModule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Modules_ModuleId",
                table: "Lessons");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Lessons");

            migrationBuilder.RenameColumn(
                name: "ModuleId",
                table: "Lessons",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Lessons_ModuleId",
                table: "Lessons",
                newName: "IX_Lessons_CourseId");

            migrationBuilder.AlterColumn<string>(
                name: "ContentFilePath",
                table: "Lessons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Lessons",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ContentFilePath", "CourseId", "Title" },
                values: new object[,]
                {
                    { 1, null, 1, "Introduction to ASP.NET Core" },
                    { 2, null, 1, "Controllers and Views" },
                    { 3, null, 2, "Getting Started with EF Core" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Lessons");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Lessons",
                newName: "ModuleId");

            migrationBuilder.RenameIndex(
                name: "IX_Lessons_CourseId",
                table: "Lessons",
                newName: "IX_Lessons_ModuleId");

            migrationBuilder.AlterColumn<string>(
                name: "ContentFilePath",
                table: "Lessons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Lessons",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modules_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "CourseId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Introduction to ASP.NET Core" },
                    { 2, 1, "Controllers and Views" },
                    { 3, 2, "Getting Started with EF Core" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Modules_CourseId",
                table: "Modules",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Modules_ModuleId",
                table: "Lessons",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
