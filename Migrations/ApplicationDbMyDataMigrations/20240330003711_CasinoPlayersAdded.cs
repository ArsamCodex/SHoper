using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SHoper.Migrations.ApplicationDbMyDataMigrations
{
    /// <inheritdoc />
    public partial class CasinoPlayersAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CasinoPlayers",
                columns: table => new
                {
                    CasinoPlayersID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Credit = table.Column<int>(type: "int", nullable: false),
                    MyProperty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CasinoPlayers", x => x.CasinoPlayersID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CasinoPlayers");
        }
    }
}
