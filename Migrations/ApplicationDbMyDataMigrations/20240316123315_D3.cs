using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SHoper.Migrations.ApplicationDbMyDataMigrations
{
    /// <inheritdoc />
    public partial class D3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_UserAsClients_UserAsClientId",
                table: "Baskets");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Baskets_BasketId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_UserAsClientId",
                table: "Baskets");

            migrationBuilder.AlterColumn<int>(
                name: "BasketId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserAsClientId",
                table: "Baskets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_UserAsClientId",
                table: "Baskets",
                column: "UserAsClientId",
                unique: true,
                filter: "[UserAsClientId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_UserAsClients_UserAsClientId",
                table: "Baskets",
                column: "UserAsClientId",
                principalTable: "UserAsClients",
                principalColumn: "UserAsClientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Baskets_BasketId",
                table: "Items",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "BasketID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_UserAsClients_UserAsClientId",
                table: "Baskets");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Baskets_BasketId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_UserAsClientId",
                table: "Baskets");

            migrationBuilder.AlterColumn<int>(
                name: "BasketId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserAsClientId",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_UserAsClientId",
                table: "Baskets",
                column: "UserAsClientId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_UserAsClients_UserAsClientId",
                table: "Baskets",
                column: "UserAsClientId",
                principalTable: "UserAsClients",
                principalColumn: "UserAsClientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Baskets_BasketId",
                table: "Items",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "BasketID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
