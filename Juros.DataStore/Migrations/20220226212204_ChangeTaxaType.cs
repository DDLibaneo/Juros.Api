using Microsoft.EntityFrameworkCore.Migrations;

namespace Juros.DataStore.Migrations
{
    public partial class ChangeTaxaType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Taxa",
                table: "Juros",
                type: "DECIMAL(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Taxa",
                table: "Juros",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(5,2)");
        }
    }
}
