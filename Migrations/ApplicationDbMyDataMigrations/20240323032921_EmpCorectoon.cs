using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SHoper.Migrations.ApplicationDbMyDataMigrations
{
    /// <inheritdoc />
    public partial class EmpCorectoon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Employee_EmployeesEmployeeID",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacation_Employee_EmployeesEmployeeID",
                table: "Vacation");

            migrationBuilder.DropIndex(
                name: "IX_Vacation_EmployeesEmployeeID",
                table: "Vacation");

            migrationBuilder.DropIndex(
                name: "IX_Department_EmployeesEmployeeID",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "EmployeesEmployeeID",
                table: "Vacation");

            migrationBuilder.DropColumn(
                name: "EmployeesEmployeeID",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "EmployeeTaskID",
                table: "Vacation",
                newName: "EmployeeID");

            migrationBuilder.RenameColumn(
                name: "EmployeeTaskID",
                table: "Department",
                newName: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Vacation_EmployeeID",
                table: "Vacation",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_EmployeeID",
                table: "Department",
                column: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Employee_EmployeeID",
                table: "Department",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacation_Employee_EmployeeID",
                table: "Vacation",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Employee_EmployeeID",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacation_Employee_EmployeeID",
                table: "Vacation");

            migrationBuilder.DropIndex(
                name: "IX_Vacation_EmployeeID",
                table: "Vacation");

            migrationBuilder.DropIndex(
                name: "IX_Department_EmployeeID",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "Vacation",
                newName: "EmployeeTaskID");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "Department",
                newName: "EmployeeTaskID");

            migrationBuilder.AddColumn<int>(
                name: "EmployeesEmployeeID",
                table: "Vacation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeesEmployeeID",
                table: "Department",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vacation_EmployeesEmployeeID",
                table: "Vacation",
                column: "EmployeesEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_EmployeesEmployeeID",
                table: "Department",
                column: "EmployeesEmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Employee_EmployeesEmployeeID",
                table: "Department",
                column: "EmployeesEmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacation_Employee_EmployeesEmployeeID",
                table: "Vacation",
                column: "EmployeesEmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID");
        }
    }
}
