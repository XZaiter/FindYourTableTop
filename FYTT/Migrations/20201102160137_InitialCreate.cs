using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FYTT.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Form",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleSystem = table.Column<string>(nullable: true),
                    PlayerName = table.Column<string>(nullable: true),
                    ExpectedPlayingTime = table.Column<DateTime>(nullable: false),
                    NumberOfPlayers = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Form");
        }
    }
}
