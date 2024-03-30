using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SHoper.Migrations.ApplicationDbMyDataMigrations
{
    /// <inheritdoc />
    public partial class AddedCasinolayer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CasinoPlayers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CasinoPlayers",
                columns: table => new
                {
                    CasinoPlayersID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Credit = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CasinoPlayers", x => x.CasinoPlayersID);
                });
        }
    }
}
