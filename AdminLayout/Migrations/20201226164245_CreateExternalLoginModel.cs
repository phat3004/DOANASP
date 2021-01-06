using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminLayout.Migrations
{
    public partial class CreateExternalLoginModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12973d3b-8179-4e4e-a309-4891abfe9338");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89489111-f69f-4344-86d1-0ce01b9ab37a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d22add4-b20e-46fa-8a1a-c090b509f1da", "e7831afc-a72f-49cf-97e7-0fd3816c72a0", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0b0f85ad-b698-4659-b1e2-1cb7b81c10b5", "d64d3c6c-5715-48db-9933-0f23611c062f", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b0f85ad-b698-4659-b1e2-1cb7b81c10b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d22add4-b20e-46fa-8a1a-c090b509f1da");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "89489111-f69f-4344-86d1-0ce01b9ab37a", "e7d4ff3e-e556-4af5-b45f-f4312ea9d4ed", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "12973d3b-8179-4e4e-a309-4891abfe9338", "ead6a31f-4e6d-4a64-b2ff-972779f96a45", "Administrator", "ADMINISTRATOR" });
        }
    }
}
