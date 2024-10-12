using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class seedlessondata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "FilePath",
                value: "https://youtu.be/qBTe6uHJS_Y?si=bnOHK8WHLtxAP13Y");

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "FilePath",
                value: "https://youtu.be/jMFaAc3sa04?si=BQUUGmAtCxV2ye47");

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "FilePath",
                value: "https://youtu.be/SIQhe-yt3mA?si=R_G3denH8jmQMu_d");

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "FilePath", "Iscompleted", "Title" },
                values: new object[,]
                {
                    { 4, 2, "https://youtu.be/Mxm81T7waO8?si=BCU_ZxdJtD9IaM8A", false, "tmp2" },
                    { 5, 1, "https://youtu.be/yxQ9CSwc_uk?si=KdLELQAnBlpOZRb4", false, "ff" },
                    { 6, 1, "https://www.youtube.com/watch?v=SIQhe-yt3mA&t=1s", false, "nn" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "040260a3-9402-445c-b640-b2f6f34efe88", "AQAAAAIAAYagAAAAEMKlU7pdiNQO7e3YzRy8dcUZMGJ04z703opBtn3LOSXGJxtPgkwe5n1fGDIcMYYYtQ==", "c6ce1927-f15d-4059-848a-04adcdb56e9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f6ba7cb-c722-4023-87f7-bbf149facaf1", "AQAAAAIAAYagAAAAEKlsynhBdgeDmytI2esM6/GKOwp95MucN+rW4KSvQdkgRvNLLPL/i8+wPxaEGRNQbQ==", "b4dda985-34bd-40b4-8c52-fb1bae049b21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8233e9f8-00d9-4dd8-af3f-585f3db86498", "AQAAAAIAAYagAAAAEEq9xKEvjmWh01ulWqNDcYWphI214jxbydKDFlg0niMFilxZ8Gnqa/IXYwHOGITVWg==", "f3bf3f39-aeda-4b94-9bb1-6066d0ec1629" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d99ca3e-055b-4895-99be-69736f612699", "AQAAAAIAAYagAAAAEI0ZRwp60Hf9SnuuyFoiHCXRV//OdqozpyPp4T07+W4VSuixRYETroH29ZN2TpP3/w==", "912ea6b6-29d5-4f73-b3af-a549ad729601" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de8da9b2-ba36-4c54-a73a-eda4dd90b06c", "AQAAAAIAAYagAAAAEIgBsq6r2N45GY+bPhYbRyLmOQyX+0HMjlZyxxILvVx9NEEUga3SmR9Fg+c8weGw2Q==", "bbf64327-b497-46be-b733-d0ac10f2a275" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "FilePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "FilePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "FilePath",
                value: null);
        }
    }
}
