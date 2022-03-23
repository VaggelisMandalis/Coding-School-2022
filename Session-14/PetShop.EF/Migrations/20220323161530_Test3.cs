using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShopEFLibrary.Migrations
{
    public partial class Test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PetFoodContext",
                table: "PetFoodContext");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PetContext",
                table: "PetContext");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeesContext",
                table: "EmployeesContext");

            migrationBuilder.RenameTable(
                name: "PetFoodContext",
                newName: "PetFood");

            migrationBuilder.RenameTable(
                name: "PetContext",
                newName: "Pet");

            migrationBuilder.RenameTable(
                name: "EmployeesContext",
                newName: "Employee");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "PetFood",
                type: "decimal(2,2)",
                precision: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "PetFood",
                type: "decimal(2,2)",
                precision: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Breed",
                table: "Pet",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SurName",
                table: "Employee",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SalaryPerMonth",
                table: "Employee",
                type: "decimal(2,2)",
                maxLength: 10,
                precision: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Employee",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PetFood",
                table: "PetFood",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pet",
                table: "Pet",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PetFood",
                table: "PetFood");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pet",
                table: "Pet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "PetFood",
                newName: "PetFoodContext");

            migrationBuilder.RenameTable(
                name: "Pet",
                newName: "PetContext");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "EmployeesContext");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "PetFoodContext",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)",
                oldPrecision: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "PetFoodContext",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)",
                oldPrecision: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Breed",
                table: "PetContext",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SurName",
                table: "EmployeesContext",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<decimal>(
                name: "SalaryPerMonth",
                table: "EmployeesContext",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)",
                oldMaxLength: 10,
                oldPrecision: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "EmployeesContext",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PetFoodContext",
                table: "PetFoodContext",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PetContext",
                table: "PetContext",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeesContext",
                table: "EmployeesContext",
                column: "ID");
        }
    }
}
