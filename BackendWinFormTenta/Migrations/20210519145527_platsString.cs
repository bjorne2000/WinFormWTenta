using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendWinFormTenta.Migrations
{
    public partial class platsString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "plats",
                table: "bokningar",
                newName: "biljetter");

            migrationBuilder.AddColumn<string>(
                name: "platser",
                table: "bokningar",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "platser",
                table: "bokningar");

            migrationBuilder.RenameColumn(
                name: "biljetter",
                table: "bokningar",
                newName: "plats");
        }
    }
}
