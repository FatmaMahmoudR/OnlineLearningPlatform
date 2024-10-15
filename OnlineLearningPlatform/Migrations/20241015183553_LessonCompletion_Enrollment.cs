using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class LessonCompletion_Enrollment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acda7447-ef56-4259-94f8-88557789a071", "AQAAAAIAAYagAAAAEFZQ9+DHndRhmjUk54FEPZyKeX2a8MZbdVN6Z6bEbM7YT3OU9LaXj7uWOQJkUjFRfQ==", "69e1e31e-00a8-4f9f-9a33-8040fc87de9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f9520e5-222f-46b7-b5d4-aeabe4bb3334", "AQAAAAIAAYagAAAAEFCzbTfJ/FCwDnPXZOBbvgebUrmnBnYV5DFC9a0Tgg5KTojfJrt59F254B/j0IO7eA==", "804592e6-1cc2-4601-bf5d-3f2f9eb0ff9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2f4adc7-efda-463f-8ec9-62592e61a2a6", "AQAAAAIAAYagAAAAEGzdQXu3Od0wSO2tqkLzZsWhS+7+d6lpzQMRsl2nMDuEVXCaRrThJnJM5KVgebU2xA==", "2a917abf-b91e-4a60-911a-23d0481468a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13cf11ba-c4aa-45df-b4ac-f6d00adc2374", "AQAAAAIAAYagAAAAEF7E2zLd9/EoVA/frONi1JANdVh5xBqml4+3bQu2o/RWBS2VNP7nocKsQOFYQLervQ==", "b887680c-08ae-4193-8bc7-4ffa09d07f27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "411e43d2-ff6a-4b02-9d82-a7c7c94811e4", "AQAAAAIAAYagAAAAENaB3AzbuwXknbodw0OSaG3OTCw2gSvPzgAvrVMX+RvWGVijJ4mDsGTUWSQ4aT1TRg==", "808430d0-9e9b-4ac8-922b-2da8e70ad1b5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "def4b539-3c1b-478c-8187-e8613acda6b2", "AQAAAAIAAYagAAAAEB5Edw38NiW3ngVqM6pvkrDyy1V0wkJwwW8mq7F7HOU1JVg6Pi4tNmV2gjr2lpyBlQ==", "2246abe0-552f-4386-942c-071f9832ab12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4dd971a4-2aee-48b9-80bb-5707cfcf19e9", "AQAAAAIAAYagAAAAEJIH0z+0x9EpUWQDxMewY0QNXuAIb69RtDZUsMItxBdr5hYfutxyJeKLax26zw2iJQ==", "20503256-0995-4a63-9559-e71dca27c273" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e1f332f-e690-44ed-94a2-c5b3ec404663", "AQAAAAIAAYagAAAAEPFoGIgAz35ajD9HEeWV9krNo1l2cZ63mbMPDnyYVG9f8CfgqIrDfQzwVrkj/n2MvQ==", "cd7d14ce-abab-474f-8466-e3dce5e6b484" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40dafab3-a165-4919-8241-14238a4a693c", "AQAAAAIAAYagAAAAEKheIWFo/siiZ7SXRb5IFtE7OaVHV4vNrpWEEUPrMjaAt3DZs0zN7MfrCcCcG/NdVw==", "590d8be9-2962-4bbe-93c7-b7d20a6f9add" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de17066b-5ba3-4224-bbd1-3f10e1801cdc", "AQAAAAIAAYagAAAAEMgdZH18buKk9nVR9OBKE0yipXu/2fjkjqj8ti7HZkTdIsqwghwTx88byvqFGyfwag==", "db36423c-4923-4e96-b218-ad4d8fa7d454" });
        }
    }
}
