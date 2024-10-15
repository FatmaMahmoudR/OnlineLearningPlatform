using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class crs_category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83cd5c72-91f3-4883-a591-9d754987dae7", "AQAAAAIAAYagAAAAEDHX0mb3cxJeyhuoGbiLT+7qDhLBOYlCywLFge3UZDCDca+FWSRBMlM9v3UDJnlH+g==", "6134d7de-f558-4461-9e21-5a9a05e515d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da907a4b-e196-472d-bfdb-a592d9d20e37", "AQAAAAIAAYagAAAAEOwdOqCrOKzmurOUwR03t3nPvC5Jes5xlpChPnQj60OhXEEiLObIDNlatmnVjzS2YA==", "c8b331d8-4066-4dfc-a625-d4f3e57872a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "955a0064-b747-48f9-b67e-263e92922760", "AQAAAAIAAYagAAAAEOILHby4u6Ne2SIiDyq+7LE/H4Zm2TIKctQ0CGYF6iP/EJK9f0mz+xmrdlFPP5QRLA==", "d6570f94-9a21-48e7-ba88-067987475ca3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fe57093-4a1d-4b54-b1b4-8503e717dcb6", "AQAAAAIAAYagAAAAEJxBmZCuk2tMc7nQWVw6eD5kFvSg+HpmzIInB5tQ/rbKJy3bV0qog0uZhs3xXyfDXg==", "1b6106d8-498b-4c31-9cb7-f684b7e06616" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eca215c6-9a93-46ab-8aaa-fcb8efe548df", "AQAAAAIAAYagAAAAEIMYrM0gBKdn3N5nNLGGdC5SmiP2NgudYD83Y2A578q28Vvca7CP7JkzrSdTG/7MxQ==", "446762e1-bfaa-4482-93d6-00c01ad98ff1" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Category",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Category",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
