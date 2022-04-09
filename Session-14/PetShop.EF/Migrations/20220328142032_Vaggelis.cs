using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShopEFLibrary.Migrations
{
    public partial class Vaggelis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionContext",
                table: "TransactionContext");

            migrationBuilder.RenameTable(
                name: "TransactionContext",
                newName: "Transaction");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Transaction",
                type: "decimal(2,2)",
                precision: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PetPrice",
                table: "Transaction",
                type: "decimal(2,2)",
                precision: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction");

            migrationBuilder.RenameTable(
                name: "Transaction",
                newName: "TransactionContext");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "TransactionContext",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)",
                oldPrecision: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "PetPrice",
                table: "TransactionContext",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)",
                oldPrecision: 2);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionContext",
                table: "TransactionContext",
                column: "ID");
        }
    }
}
