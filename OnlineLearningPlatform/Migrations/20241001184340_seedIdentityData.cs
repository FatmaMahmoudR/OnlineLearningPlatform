using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class seedIdentityData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "540fa4db-060f-4f1b-b60a-dd199bfe4001", null, "Student", "STUDENT" },
                    { "540fa4db-060f-4f1b-b60a-dd199bfe4111", null, "Instructor", "INSTRUCTOR" },
                    { "540fa4db-060f-4f1b-b60a-dd199bfe4f0b", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "62fe5285-fd68-4711-ae93-673787f4a001", 0, "b1da4002-2f97-4eb4-8901-b3d0d498586d", "user1@user.com", true, false, null, "USER1@USER.COM", "INSTRUCTOR", "AQAAAAIAAYagAAAAELeXSZUHJ6YszUBdzvXO6Xvn/ghAbdam2+apdcq9SxFw72CuQtF5WyuTjM3U7QjvSw==", null, false, "628ed9e9-17f7-405b-b78a-d84ecf42f369", false, "instructor" },
                    { "62fe5285-fd68-4711-ae93-673787f4a111", 0, "eece34dd-a1a5-4798-8b1c-063cebff34d1", "user2@user.com", true, false, null, "USER2@USER.COM", "STUDENT", "AQAAAAIAAYagAAAAELJtxC4/BlrT+Ry1eJ6K0Kt6PcfttKExTCNM5AvlhtSKBJd49PBzejCuA4z0HEdhww==", null, false, "c5b5d035-b7fb-4203-9cd3-1dc6e969a24d", false, "student" },
                    { "62fe5285-fd68-4711-ae93-673787f4ac66", 0, "d6a33810-90e8-4bee-8674-4300e85c38ce", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEPQu4luY4v6mISAvwIyyRl39pDNngfSuCUSiNixWuhkme3WRcpif2E7aHTrZTuFOMQ==", null, false, "ab82d800-7692-4ce6-ba22-959446eae9e1", false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "540fa4db-060f-4f1b-b60a-dd199bfe4111", "62fe5285-fd68-4711-ae93-673787f4a001" },
                    { "540fa4db-060f-4f1b-b60a-dd199bfe4001", "62fe5285-fd68-4711-ae93-673787f4a111" },
                    { "540fa4db-060f-4f1b-b60a-dd199bfe4001", "62fe5285-fd68-4711-ae93-673787f4ac66" },
                    { "540fa4db-060f-4f1b-b60a-dd199bfe4111", "62fe5285-fd68-4711-ae93-673787f4ac66" },
                    { "540fa4db-060f-4f1b-b60a-dd199bfe4f0b", "62fe5285-fd68-4711-ae93-673787f4ac66" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "540fa4db-060f-4f1b-b60a-dd199bfe4111", "62fe5285-fd68-4711-ae93-673787f4a001" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "540fa4db-060f-4f1b-b60a-dd199bfe4001", "62fe5285-fd68-4711-ae93-673787f4a111" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "540fa4db-060f-4f1b-b60a-dd199bfe4001", "62fe5285-fd68-4711-ae93-673787f4ac66" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "540fa4db-060f-4f1b-b60a-dd199bfe4111", "62fe5285-fd68-4711-ae93-673787f4ac66" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "540fa4db-060f-4f1b-b60a-dd199bfe4f0b", "62fe5285-fd68-4711-ae93-673787f4ac66" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "540fa4db-060f-4f1b-b60a-dd199bfe4001");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "540fa4db-060f-4f1b-b60a-dd199bfe4111");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "540fa4db-060f-4f1b-b60a-dd199bfe4f0b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66");
        }
    }
}
