using Microsoft.EntityFrameworkCore.Migrations;

namespace Parlit.Data.Migrations
{
    public partial class AddingMigrationAfterAddingModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f91cab8-2292-40bb-b425-8711e3bc0450");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "37039792-ffde-4cfa-8202-3475a772e974", "f9f28b78-5055-4ce7-9f90-bea23046d7c0", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37039792-ffde-4cfa-8202-3475a772e974");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0f91cab8-2292-40bb-b425-8711e3bc0450", "e9bc484c-9fbf-45e4-82e7-fa58456de457", "User", "USER" });
        }
    }
}
