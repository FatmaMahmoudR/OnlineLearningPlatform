using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class AddMapCompletionStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e35529c-0be9-4953-a59a-d4a395a4d6cc", "AQAAAAIAAYagAAAAEAoCYk6nMK7AXpQlwQ/f/Uyetr6JPW+uRjh9cBjDfYJFEJVAxrLFmcoU6t/Ht51CeA==", "b2999174-0073-425f-924d-ca951a1e10a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79463733-dac4-438a-95cf-4d8312a02dfb", "AQAAAAIAAYagAAAAEJLCRNznd9iO+K8DYZ7bQZNjUZvSpYaFXPemrwJ/gQ14wDRcsBbqpb12rjPPWCvh8g==", "1b496f04-38c7-4fff-aa09-ebafb7e4602d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c09df8f0-12b6-425b-9b8e-40abf9147d9b", "AQAAAAIAAYagAAAAEI5/90lKUSAONje445XIio0A4ySYyB6On94V0kdkVVR6GrN3zlbhKTerutbcSRIyFg==", "9f86f230-bdca-4ad8-8945-7d5948e5a194" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "499c2a6e-8cce-4267-97e6-8a052503988e", "AQAAAAIAAYagAAAAENwf+JIaOFgFdZ+onpvpmfVzxoEwJceKsbAA8F2iriRN6zSS1o41tmZSelv5g9prfA==", "cda214e8-ec8a-43e1-b97a-cd1fd1f43a50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df3e5ca4-3eb0-49f8-a927-10fa58db9736", "AQAAAAIAAYagAAAAEEjx1PdK87IPikPUcHnkHMgbdvz8cwXSaBl1eAcRiDDvcto0SnZJlVUFegJgpT4TWA==", "ca52f615-f063-4c71-95ed-e1aabd9b9533" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7570636d-873a-47d9-8f92-41282cdeea62", "AQAAAAIAAYagAAAAECNWrAwGzdHulWJiW6IWni+r2GpaNohtiPpx+2a/48Sa3j89T80m0CiOPBAi+y80Ug==", "4e4691cc-1547-470e-bdaa-afa00823dee5" });
        }
    }
}
