using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminLayout.Migrations
{
    public partial class add_addresss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a740cea0-ed27-4e80-838d-1c6c108b85ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed718fc1-cbbc-42f1-bbd2-91adf9fd249c");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2eeb1df0-d7bd-4ede-ac06-3f1277487244", "13e8900c-57f0-48ad-a69d-9488d4f683c8", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8bcc04d1-d445-468a-bc93-b5e0a94338a4", "3311b1dc-8128-487b-b020-f00e3b925269", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2eeb1df0-d7bd-4ede-ac06-3f1277487244");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8bcc04d1-d445-468a-bc93-b5e0a94338a4");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a740cea0-ed27-4e80-838d-1c6c108b85ef", "5d252886-16a8-46d1-ac3f-ba9d3ad98abb", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed718fc1-cbbc-42f1-bbd2-91adf9fd249c", "3336656a-78a7-4cba-8bf0-e08ee81d9e36", "Administrator", "ADMINISTRATOR" });
        }
    }
}
