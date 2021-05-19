using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendWinFormTenta.Migrations
{
    public partial class FixPlatser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "plats1",
                table: "salonger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "plats10",
                table: "salonger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "plats11",
                table: "salonger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "plats12",
                table: "salonger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "plats13",
                table: "salonger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "plats14",
                table: "salonger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "plats15",
                table: "salonger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "plats16",
                table: "salonger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "plats17",
                table: "salonger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "plats18",
                table: "salonger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "plats19",
                table: "salonger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "plats2",
                table: "salonger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "plats20",
                table: "salonger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "plats3",
                table: "salonger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "plats4",
                table: "salonger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "plats5",
                table: "salonger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "plats6",
                table: "salonger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "plats7",
                table: "salonger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "plats8",
                table: "salonger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "plats9",
                table: "salonger",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "plats1",
                table: "salonger");

            migrationBuilder.DropColumn(
                name: "plats10",
                table: "salonger");

            migrationBuilder.DropColumn(
                name: "plats11",
                table: "salonger");

            migrationBuilder.DropColumn(
                name: "plats12",
                table: "salonger");

            migrationBuilder.DropColumn(
                name: "plats13",
                table: "salonger");

            migrationBuilder.DropColumn(
                name: "plats14",
                table: "salonger");

            migrationBuilder.DropColumn(
                name: "plats15",
                table: "salonger");

            migrationBuilder.DropColumn(
                name: "plats16",
                table: "salonger");

            migrationBuilder.DropColumn(
                name: "plats17",
                table: "salonger");

            migrationBuilder.DropColumn(
                name: "plats18",
                table: "salonger");

            migrationBuilder.DropColumn(
                name: "plats19",
                table: "salonger");

            migrationBuilder.DropColumn(
                name: "plats2",
                table: "salonger");

            migrationBuilder.DropColumn(
                name: "plats20",
                table: "salonger");

            migrationBuilder.DropColumn(
                name: "plats3",
                table: "salonger");

            migrationBuilder.DropColumn(
                name: "plats4",
                table: "salonger");

            migrationBuilder.DropColumn(
                name: "plats5",
                table: "salonger");

            migrationBuilder.DropColumn(
                name: "plats6",
                table: "salonger");

            migrationBuilder.DropColumn(
                name: "plats7",
                table: "salonger");

            migrationBuilder.DropColumn(
                name: "plats8",
                table: "salonger");

            migrationBuilder.DropColumn(
                name: "plats9",
                table: "salonger");
        }
    }
}
