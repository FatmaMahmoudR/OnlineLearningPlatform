using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class init_14oct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfe62004-7cfd-4382-84dd-f393d2e81d45", "AQAAAAIAAYagAAAAEAPvs8XaEAq2VXJZFYcoYmkYcDZXUDe6NRW6Mgv98UIGLWryhu6Ah7PN47OekNxpJw==", "215438ad-6f7f-4f95-9021-73aeac8ecea1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a423c28f-8367-41b4-be69-b6321f1a0ffb", "AQAAAAIAAYagAAAAEIlMg6Diy6sywORtuGQWpT2U3Jy6F60UkTlu2xjW7MlE+yeYO1XYATfm+309YUO71A==", "0cb69311-6d7a-426b-8321-5a14b09a567a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "322f9c60-51d4-400c-9b89-b4d7fb47c2c0", "AQAAAAIAAYagAAAAEApVpjPOgh/XaUEUtzWRBNmL0Ll5zqwSu/5M02McX69CLSFBJg2s27/YRTz+F+C26A==", "35d88824-2a46-45e7-8865-dd26b8b62c8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3daecf7-1ffb-4050-a5be-709e9603430f", "AQAAAAIAAYagAAAAECitYlY8chNUlfcT5GoVcZBaAU0MzsL8MELso3WM6wt+3Y7sqa4DPzoXeDHUWSla9g==", "af37472a-4146-47ff-b0a6-2c73c9935b11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62beb7c3-c593-468e-bc67-eee5218a0810", "AQAAAAIAAYagAAAAEIueUYkgqQnHBSNqP1GksUO5fuPh2vpLDg9PV3S9Q22Aw9dkBL1I67hBzcOg4XUeTA==", "4850d75d-89c4-489c-81bd-d1ce440d33ad" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b47913bf-cd9c-44d6-871d-39f3fa89b41c", "AQAAAAIAAYagAAAAEJ3FidrlW4Qk/qe2/CIjCVQWZ6z0c46C4IcKF1/rQuK1pBcny27Hyqp08CT82SybMA==", "28bb2926-7085-46dc-b7a4-b1d2e9b0af9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c98a61c6-5d3c-494a-99b9-e4e96ce985d5", "AQAAAAIAAYagAAAAECRIi0ge7+VRj8hMZfzyL3eHISAraI9gwSJIkmUZ7WINePkdkJHW+mx7SAmGkPSdIQ==", "4af3a1a8-f8a3-4983-a8f0-9c73bfc57f4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c130eb72-222e-4661-b60d-e69ccbee0652", "AQAAAAIAAYagAAAAEDYrlH6S4uLYCDN6XTsIjWN6pwSOE3H2wjVKly6k9cuXbSDjuj6GV7uQRYXrK8E9wA==", "44fd95e7-4867-4481-ab0e-de66ee9d06f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33d0e753-6ba8-4dd5-ab8c-6eac75eee03a", "AQAAAAIAAYagAAAAEJi2z7tLxqongxZTC4m2K1SRrXKKCnC7i8ZX2lbTv35OLgG4kFf3ptI3hjrz2pkLsA==", "9b9a3a66-e2a8-43d1-972d-22a7582b4110" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbbc4f23-f650-4217-9e8b-630643a019c5", "AQAAAAIAAYagAAAAECUmh+eTHjts4f350qsOKcJ+GtldWMBF3KYVURdu9w1t3ZaMxDSw78xqJ9UvCB+HSA==", "52ef55ff-31c9-4b9d-8e78-619836d76c1b" });
        }
    }
}
