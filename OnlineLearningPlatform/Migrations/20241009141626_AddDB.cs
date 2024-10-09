using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class AddDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24e633c4-a547-42c3-9158-682bbacbbfa4", "AQAAAAIAAYagAAAAEFPXQNV8GyQFLgEBTPOuTWhfx9nxz6zHZcCc1g04QpdQxRqeSLJaZA9WNxVQ9aA91Q==", "c00eecee-efea-4b70-b3bb-a484e9cc3c06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cec11a8-ce86-4bc0-af8d-109ac5fd288e", "AQAAAAIAAYagAAAAEPeAK0/nUCp4FKQnUdiEr0PbSUl3XXwMEY4mUZu5ugy42mNhesI3A8aei99KAxczTA==", "fce49183-a3cc-496a-8177-6462ad6570ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1056a795-aad1-4235-bd43-fe134ebd8e6e", "AQAAAAIAAYagAAAAEA+7woLQbX9qaDpX+uCf4a6Slpqs3jliBU1xpZyUc69t/qduL15o0AAQuKRIgNuq8w==", "fdb13931-4941-409f-a2f2-b59ca89ece98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f39b2ee-7309-490e-8fb2-65eaf4a8d4d3", "AQAAAAIAAYagAAAAEKEHrCM+8Q3JZsUyC1ejOPU7NMDHutZ8gdYG9SpfmZlbXX88jTNtI1SxrmKFgX/QUQ==", "c2663eb2-acb8-4347-93ea-8b2a38fd127e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c6d3396-7b80-4af5-b89f-ce1804524e97", "AQAAAAIAAYagAAAAEKk/2QPb5NbfBVNwzoib7PSzJiUpI2O0ULcKHG/nmy/bXFAznBMWYGoI/AmPTfpcWA==", "31e88f8d-1cd9-4f12-b1eb-476e95b75f24" });
        }
    }
}
