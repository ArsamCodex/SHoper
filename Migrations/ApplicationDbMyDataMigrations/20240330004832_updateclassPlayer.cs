using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SHoper.Migrations.ApplicationDbMyDataMigrations
{
    /// <inheritdoc />
    public partial class updateclassPlayer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "CasinoPlayers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "CasinoPlayers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
