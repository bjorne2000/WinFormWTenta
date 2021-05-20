using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendWinFormTenta.Migrations
{
    public partial class removeBiljett : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "biljetter",
                table: "bokningar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "biljetter",
                table: "bokningar",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
