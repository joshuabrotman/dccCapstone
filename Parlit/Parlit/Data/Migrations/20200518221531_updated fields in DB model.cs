using Microsoft.EntityFrameworkCore.Migrations;

namespace Parlit.Data.Migrations
{
    public partial class updatedfieldsinDBmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66fc5d3f-ce53-47e0-91d7-a528751048e6");

            migrationBuilder.AddColumn<int>(
                name: "rank",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "category",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "hypostasis",
                table: "Posts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0f91cab8-2292-40bb-b425-8711e3bc0450", "e9bc484c-9fbf-45e4-82e7-fa58456de457", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f91cab8-2292-40bb-b425-8711e3bc0450");

            migrationBuilder.DropColumn(
                name: "rank",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "URL",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "category",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "hypostasis",
                table: "Posts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "66fc5d3f-ce53-47e0-91d7-a528751048e6", "f41902f4-c7c4-406d-adb8-c279b13aa4e5", "User", "USER" });
        }
    }
}
