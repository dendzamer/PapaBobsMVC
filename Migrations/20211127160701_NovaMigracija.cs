using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PapaBob.Migrations
{
    public partial class NovaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Onions",
                table: "Order",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Onions",
                table: "Order");
        }
    }
}
