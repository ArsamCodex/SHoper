using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SHoper.Migrations.ApplicationDbMyDataMigrations
{
    /// <inheritdoc />
    public partial class AddCasinoPlayerClass : Migration
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
                    Userid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Credit = table.Column<int>(type: "int", nullable: false)
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
