using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendWinFormTenta.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "filmer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    filmNamn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filmer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "kunder",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teleNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    namn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    perssonNr = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kunder", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "salonger",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    salongNum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salonger", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "visningar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    visningsSalongID = table.Column<int>(type: "int", nullable: true),
                    visningsFilmID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visningar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_visningar_filmer_visningsFilmID",
                        column: x => x.visningsFilmID,
                        principalTable: "filmer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_visningar_salonger_visningsSalongID",
                        column: x => x.visningsSalongID,
                        principalTable: "salonger",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "bokningar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bokadVisningID = table.Column<int>(type: "int", nullable: true),
                    bokadKundID = table.Column<int>(type: "int", nullable: true),
                    plats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bokningar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_bokningar_kunder_bokadKundID",
                        column: x => x.bokadKundID,
                        principalTable: "kunder",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_bokningar_visningar_bokadVisningID",
                        column: x => x.bokadVisningID,
                        principalTable: "visningar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bokningar_bokadKundID",
                table: "bokningar",
                column: "bokadKundID");

            migrationBuilder.CreateIndex(
                name: "IX_bokningar_bokadVisningID",
                table: "bokningar",
                column: "bokadVisningID");

            migrationBuilder.CreateIndex(
                name: "IX_visningar_visningsFilmID",
                table: "visningar",
                column: "visningsFilmID");

            migrationBuilder.CreateIndex(
                name: "IX_visningar_visningsSalongID",
                table: "visningar",
                column: "visningsSalongID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bokningar");

            migrationBuilder.DropTable(
                name: "kunder");

            migrationBuilder.DropTable(
                name: "visningar");

            migrationBuilder.DropTable(
                name: "filmer");

            migrationBuilder.DropTable(
                name: "salonger");
        }
    }
}
