using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class drop_crs_category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Courses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4be5384-bce7-484e-b3ee-97ccea0161b7", "AQAAAAIAAYagAAAAECDoWvEOynRTFxo0zE3tnL8d1rkmhrfZeGk7TWtYLJVqFrS0jAoNFawZ4tmZCDZqnw==", "1b16cd73-3ca2-4062-bb5e-09a92f54aac8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a8c5a48-f866-4cbd-bfc0-f9bba9b19b51", "AQAAAAIAAYagAAAAEFZnAzKaVbbAaMeK3IjNVJIdlBWrzzmOj1u1rpkJW+VmOLerIiSq+gBD4heVomhPpg==", "24c5cdb5-88db-4e38-88df-b69dfad54055" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af09ab12-ee5d-44ee-a79e-c15957809b90", "AQAAAAIAAYagAAAAENBfxx062NjvfQMJTmX7YgXh6UwnEYnNUDZqNQ2Sv+MLjM8q9ep9a6th72YkSgLlPg==", "6a98a42c-3731-4e91-b222-2ed3618e7df1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5224f16-f707-4260-b258-f8a3f8fd17dc", "AQAAAAIAAYagAAAAEDnXm0aHzpNe/1TWerHFeghFQSLINQ3RUG9yn2NKrynlYzi0AByrLp3RRT1jUiJ4fg==", "e162f82a-720c-49bf-ac8e-8a6f66c16b29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2840cefa-373a-4573-acde-0f20c0241afa", "AQAAAAIAAYagAAAAEMqWGJgCZWQu0cCQCectoFKQbRrHYOSkW/+SxZ2cpv0cpoSG9aJCEZATLAaFdV7bog==", "6901730b-6a37-47dc-9350-abd040f4a234" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9cf6842-c1e6-4fbd-a46c-4655b24050c5", "AQAAAAIAAYagAAAAEPE8TfGcWiYbnY0KxMVltJo4fjcR3rnVp+FeZ4oQg9vM+Yyox+BMsl6TYQTc1zcGdg==", "922701bd-593f-4c6e-8496-d779075d099f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a4c81b7-514c-4da3-ba39-7ad67e73e8bc", "AQAAAAIAAYagAAAAEO2H4sB1PuXUrKpBv5TmXEKR+z983RwgRH7Dtf8fxFXiBqtbMnCuBa96gQ87OzaOHw==", "df356651-1e71-4e91-b32a-675629a3a86b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ed0c474-e1fb-469f-aa7c-c8c07cd1c97d", "AQAAAAIAAYagAAAAEPHAGUvg+Ke1+mwQ15PfpzEtjN6MnjfvvoOBEGpum2QMP3JzOG8E3ScWsNqtIc2y1A==", "d0b713ef-ef53-4eb6-aff5-a2911e5e1b9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12054b5d-07c9-4322-94fc-79881efbcd3c", "AQAAAAIAAYagAAAAELb91pkj+f+y34h88s+WrEuiJq4SUlzI5rldtiZA7FdtLg9fHGFGnw2EIJjTcHdtfg==", "fc9c2ae0-b0f1-431e-a644-628eeccc0291" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "194d56a0-991d-4534-b993-9e237a441690", "AQAAAAIAAYagAAAAEFFrdPl2NC4xlxzFUHY65nSfiujtuwAEgb55r+z/FdLIICKsUqNCo2sW9HT+Wfkpog==", "096cd867-56d0-4a5d-94f0-93c0feed0aa5" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Category",
                value: "Back-end");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Category",
                value: "Back-end");
        }
    }
}
