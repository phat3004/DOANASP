using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminLayout.Migrations
{
    public partial class change_orderModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2eeb1df0-d7bd-4ede-ac06-3f1277487244");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8bcc04d1-d445-468a-bc93-b5e0a94338a4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "83b28fee-c35e-45d0-ba47-884eda3bee1b", "32ff3e53-8299-4082-a91d-8c048c0cd46e", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a22a8eb3-f85c-475d-8c58-29f16527c4d3", "d2c1be0d-47e2-4ffe-95da-720a77a5acee", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83b28fee-c35e-45d0-ba47-884eda3bee1b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a22a8eb3-f85c-475d-8c58-29f16527c4d3");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2eeb1df0-d7bd-4ede-ac06-3f1277487244", "13e8900c-57f0-48ad-a69d-9488d4f683c8", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8bcc04d1-d445-468a-bc93-b5e0a94338a4", "3311b1dc-8128-487b-b020-f00e3b925269", "Administrator", "ADMINISTRATOR" });
        }
    }
}
