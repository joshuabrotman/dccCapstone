using Microsoft.EntityFrameworkCore.Migrations;

namespace Parlit.Data.Migrations
{
    public partial class modifiedParlitorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe9eac2d-ed9d-45c0-ac08-eb418831b38d");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "parlitor",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3e782d6-2017-42ee-8387-fbcbd34d28be", "9b4b56d4-1e2d-4db4-8a09-06d81041a68f", "Parlitor", "PARLITOR" });

            migrationBuilder.CreateIndex(
                name: "IX_parlitor_IdentityUserId",
                table: "parlitor",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_parlitor_AspNetUsers_IdentityUserId",
                table: "parlitor",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_parlitor_AspNetUsers_IdentityUserId",
                table: "parlitor");

            migrationBuilder.DropIndex(
                name: "IX_parlitor_IdentityUserId",
                table: "parlitor");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3e782d6-2017-42ee-8387-fbcbd34d28be");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "parlitor");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe9eac2d-ed9d-45c0-ac08-eb418831b38d", "730dd607-4fd7-4ec7-95d2-1a194a8fa2b3", "Parlitor", "PARLITOR" });
        }
    }
}
