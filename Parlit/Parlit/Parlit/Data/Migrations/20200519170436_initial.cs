using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parlit.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "parlitor",
                columns: table => new
                {
                    parlitorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    parlitorName = table.Column<int>(nullable: false),
                    rank = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parlitor", x => x.parlitorID);
                });

            migrationBuilder.CreateTable(
                name: "submission",
                columns: table => new
                {
                    submissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    parlitorID = table.Column<int>(nullable: false),
                    timeSubmitted = table.Column<DateTime>(nullable: false),
                    content = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true),
                    category = table.Column<string>(nullable: true),
                    hypostasis = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_submission", x => x.submissionID);
                });

            migrationBuilder.CreateTable(
                name: "voteHistory",
                columns: table => new
                {
                    voteHistoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    voteHistoryDate = table.Column<DateTime>(nullable: false),
                    voteHistoryValue = table.Column<bool>(nullable: false),
                    parlitorID = table.Column<int>(nullable: false),
                    submissionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_voteHistory", x => x.voteHistoryID);
                });

            migrationBuilder.CreateTable(
                name: "voteTally",
                columns: table => new
                {
                    voteTallyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    submissionID = table.Column<int>(nullable: false),
                    voteCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_voteTally", x => x.voteTallyID);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7bda8478-b4c3-44fe-9b8f-95448f46e18b", "2c093a63-f2b7-4421-aae1-12907c17b752", "Parlitor", "PARLITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "parlitor");

            migrationBuilder.DropTable(
                name: "submission");

            migrationBuilder.DropTable(
                name: "voteHistory");

            migrationBuilder.DropTable(
                name: "voteTally");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bda8478-b4c3-44fe-9b8f-95448f46e18b");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
