using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class AddMapCompletionStatusToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CompletionStatus",
                table: "Enrollments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CompletionStatus",
                table: "Enrollments",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e1a2a48-cf1f-4888-b994-e8241e2ff423", "AQAAAAIAAYagAAAAEKcmfNxvt5UPrJoO8bpiWhCmLOmlchH3D/00I3N7BiSeJo/vLc4NgwD77iCoFuoKhg==", "3f22f1cb-3cd1-4517-80af-44fac3a71514" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4a111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd52a6a5-d36b-438e-b937-590f8699c2b9", "AQAAAAIAAYagAAAAEDDepqV/0z062LK3gY9P3BcBtYLoCXzWk50FwwoByTho78TOTPGRGuGaLfRJfqsBwA==", "1ea82663-ff66-48cd-96b6-99d0a763ef4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fe5285-fd68-4711-ae93-673787f4ac66",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40337c16-33de-4682-8654-68f3393566d7", "AQAAAAIAAYagAAAAEAZdN94bDvg3AUZxyscGYLjeaLPiL615y1++elqUfH105IvjDBNTHfUNVpycQrNLPg==", "c0eb3f7c-412e-4b99-8297-4056b9d5333f" });
        }
    }
}
