using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class Add_DataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22cee08d-2d43-451e-a7e5-97f0a35285a9", "AQAAAAIAAYagAAAAENdgS6fYCTNyI2mpXA6lqPzvlYpEHt0ICMxlCZhed7r4NEtT3GvYQWO6EDGVS9KocQ==", "494a813d-6006-4f56-9031-60e52348dcaf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49e7e0e6-a91f-42c7-9345-4156a0a0a9ad", "AQAAAAIAAYagAAAAEJ+Ux0vEOTpMydz8icH1JmYuXZj6c9BqjSZ7hSfBkgai68njwtx5TEgQ9aGByyq51g==", "7f7d9d32-bb29-40ff-a0cc-87b766f67352" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd2e214f-7755-40f2-ae42-820015011c26", "AQAAAAIAAYagAAAAEDy6cbQiE3fDEXcfHvqqaLoxyV2wBJLq1FpLW5qUKKC3akTTc5wZEWD5zyD3N0Vgxw==", "3f71a67f-9176-4f51-a4e1-408b34f594ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14877c73-d876-4c76-a025-38007d7986ee", "AQAAAAIAAYagAAAAECoo9zDNq5CzD2Z4K4p5a/i8fGld/a9UGoYDy3GW6/uPSuEHPvZH+xPdH/gwtNdLUQ==", "3ba13794-92e2-4633-ba58-75c76b5e42db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1dea2b61-e87e-45f3-be5f-cd3608ee1a8e", "AQAAAAIAAYagAAAAEJAmusI66fUu4tYg2RVrNZ6MeRSUnNfWh2mVHklvwka+7axmY0GGZWqy/7TBU5l7vA==", "c52bef16-01b7-4981-889d-4c95282569d8" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9333fdb-4fcb-40a0-b06f-e7eb9e56ae0d", "AQAAAAIAAYagAAAAEEOggBSB2lLEdfqpb8GTgXM/7gCrpc3Y/8CmFt4u3hGa+K1t7qPEEcjfR3O/1hcq3w==", "9f0daab8-ab2f-4481-964a-329e73695e9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f235622-1c3b-44d7-9080-f79b6e470f4b", "AQAAAAIAAYagAAAAEKYXKXer6oXgwpI2D6uf251FUTJIsFmFxFCl2+mRKOUK9lSb9KcGKS31jFkK4MUT4A==", "19a0f5b4-c385-4079-b7fb-1f21bf6e228d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c0da449-2b2f-4809-9e64-631d5616fdf3", "AQAAAAIAAYagAAAAECXLKTHkUC+Dn1/2zmNIsyZeMj1ky7wBeP0cY8Ta1BaJSvYhahUjuS1NXyPyjv5qOQ==", "ce1cd5ab-2dad-45ec-b2c7-ee406554a44f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "749e8ab6-0f07-44ef-a562-e163f177e8cd", "AQAAAAIAAYagAAAAEIcYRBFNGrlMmvTNNlZXu1ij23s/AFqFb4vaVnjNSWIfeiiSOv2n4F7x/gQj0+z8Ew==", "c4b3f225-7beb-465c-a025-a40cf6f1afc8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8a3dd0a-9b75-4999-93fc-c9abc28a064e", "AQAAAAIAAYagAAAAEMRpo9Vm3OZI1ovZjpGIN1GWYzwVqydGKr3Tw+d6xK1EaB5o0X/LDU22ZDwJkZBSiA==", "72149a0d-8180-4099-b6f2-d538c21306b1" });
        }
    }
}
