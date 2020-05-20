using Microsoft.EntityFrameworkCore.Migrations;

namespace Parlit.Data.Migrations
{
    public partial class AddedUpvotesToParlitor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bda8478-b4c3-44fe-9b8f-95448f46e18b");

            migrationBuilder.AddColumn<int>(
                name: "upvotes",
                table: "parlitor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe9eac2d-ed9d-45c0-ac08-eb418831b38d", "730dd607-4fd7-4ec7-95d2-1a194a8fa2b3", "Parlitor", "PARLITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe9eac2d-ed9d-45c0-ac08-eb418831b38d");

            migrationBuilder.DropColumn(
                name: "upvotes",
                table: "parlitor");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7bda8478-b4c3-44fe-9b8f-95448f46e18b", "2c093a63-f2b7-4421-aae1-12907c17b752", "Parlitor", "PARLITOR" });
        }
    }
}
