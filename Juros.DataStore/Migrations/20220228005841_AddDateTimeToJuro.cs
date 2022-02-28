using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Juros.DataStore.Migrations
{
    public partial class AddDateTimeToJuro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Juros",
                nullable: false,
                defaultValue: DateTime.Now);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Juros");
        }
    }
}
