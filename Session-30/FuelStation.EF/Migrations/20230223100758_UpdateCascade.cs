using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FuelStation.EF.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLines_Transactions_TransactionID",
                table: "TransactionLines");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalValue",
                table: "Transactions",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLines_Transactions_TransactionID",
                table: "TransactionLines",
                column: "TransactionID",
                principalTable: "Transactions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLines_Transactions_TransactionID",
                table: "TransactionLines");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalValue",
                table: "Transactions",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLines_Transactions_TransactionID",
                table: "TransactionLines",
                column: "TransactionID",
                principalTable: "Transactions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
