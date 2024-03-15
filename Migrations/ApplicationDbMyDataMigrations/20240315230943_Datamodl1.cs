using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SHoper.Migrations.ApplicationDbMyDataMigrations
{
    /// <inheritdoc />
    public partial class Datamodl1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserAsClient",
                columns: table => new
                {
                    UserAsClientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsernameInForum = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAsClient", x => x.UserAsClientID);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemPrice = table.Column<double>(type: "float", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserAsClientID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemsID);
                    table.ForeignKey(
                        name: "FK_Items_UserAsClient_UserAsClientID",
                        column: x => x.UserAsClientID,
                        principalTable: "UserAsClient",
                        principalColumn: "UserAsClientID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_UserAsClientID",
                table: "Items",
                column: "UserAsClientID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "UserAsClient");
        }
    }
}
