using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class AddUserProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1899d5b1-bedc-4560-ab77-bb8a1616830f", "AQAAAAIAAYagAAAAEPdSnB0KHUhHxdurfD3/1eYzpcu8/KCkU0mvDtYCBUVHDXK+3fv71q3hLPVfL48KFA==", "4d79d601-9d45-41ed-8a7f-4de55cb3f60c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2a72c77-b5a3-41b6-a4bd-9a4a01ef5ad7", "AQAAAAIAAYagAAAAEGV2qCTJR9LHwcSo4DvdXoJ0P6qCuSDKpIX85TS9eNfT1KrE+rwtbHRwfCKD/76g8Q==", "59eecaf6-e7d3-4616-94a2-3c076930c6f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88141bad-61a3-491a-ace4-96aaabc6a71e", "AQAAAAIAAYagAAAAECfqkJLFRB0ymdZKhLNO2aUqjkpY7b583pnZeLTvHfjxxq1wvLxEyhR/Ke0dBG/jcQ==", "d5c2bd0b-50bc-488b-9387-de8d585aac3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de45d646-fa27-4a93-9522-51d80e54d73b", "AQAAAAIAAYagAAAAECFUjCSV3arByho7rb67T9jzozuD7t0+18RLW4Df7AQ4Za5HcjluoGkrrOKvQ7NdJw==", "f5ce884f-77c1-45db-bf16-60440660658e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f72a0530-cd31-474b-b9d1-7b096bea5411", "AQAAAAIAAYagAAAAEFI1enfuWt2PBoxKqbkjbxmMd+W7pFT8TuPg7G6DNOpfU3E27hS4DGqptV+FimRB5g==", "9de6c36e-e102-48e3-b889-f52cca4b8954" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d6302fc-d3fb-4851-baa4-6020716802b9", "AQAAAAIAAYagAAAAEJ+raZEBPmDgcWTwhLnA+u3bwTUJsKhNKQWx63fpbcuq/OtLKggXV8ISM50UNH1ylg==", "5b6b0558-8a45-4797-a002-3e3a4e82eb17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "629c0b3a-f8b8-4943-b0d2-87d11afd4aba", "AQAAAAIAAYagAAAAEMXwYRuLMXj8o5RH8kcEn7DcHTTusK69yTTdWgX5miF+dVLveawszlLe+9dOhhqy2g==", "d27e28ce-c3d7-4cda-a0cf-7ab278417544" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8044503d-4aa4-4f0c-955a-d0aa84e20f4c", "AQAAAAIAAYagAAAAEEGAOsKMGZ1id+VS9EoOL+uXvMUzUsO4VFBT6NX6rxKS+m2yVDsoS9btLIf3rhbBng==", "a2768082-3e9d-4abe-8586-089b9aa52432" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2f5baef-5e7d-48f1-a3e4-f8f07730617b", "AQAAAAIAAYagAAAAELV1h6fTD8djqV32OAMwsPo5o0vg55V7CVQYIaaje4k5MvmAbfFmEj5GAVsQeW47xA==", "5c42baec-c4d2-45cb-b013-59eed7060f2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1cf63c0-9914-4d38-9d9d-bd5277510287", "AQAAAAIAAYagAAAAEGye8LalHQn9IgA+d5nuj/pHhbVrn2oU2qOaIPBqCCrlSk8USmUSNkwbeC+nuaU8yw==", "6ab528b0-b7f7-42b1-9270-de88b8cad8d6" });
        }
    }
}
