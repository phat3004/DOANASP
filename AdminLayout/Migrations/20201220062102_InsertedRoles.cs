using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminLayout.Migrations
{
    public partial class InsertedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "89489111-f69f-4344-86d1-0ce01b9ab37a", "e7d4ff3e-e556-4af5-b45f-f4312ea9d4ed", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "12973d3b-8179-4e4e-a309-4891abfe9338", "ead6a31f-4e6d-4a64-b2ff-972779f96a45", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12973d3b-8179-4e4e-a309-4891abfe9338");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89489111-f69f-4344-86d1-0ce01b9ab37a");
        }
    }
}
