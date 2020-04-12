using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hackathon.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KontaktOsobe",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ime = table.Column<string>(nullable: true),
                    prezime = table.Column<string>(nullable: true),
                    struka = table.Column<string>(nullable: true),
                    brojTelefona = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KontaktOsobe", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Osobe",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ime = table.Column<string>(nullable: true),
                    prezime = table.Column<string>(nullable: true),
                    datumRodenja = table.Column<DateTime>(nullable: false),
                    struka = table.Column<string>(nullable: true),
                    brojTelefona = table.Column<string>(nullable: true),
                    kontaktOsobaid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osobe", x => x.id);
                    table.ForeignKey(
                        name: "FK_Osobe_KontaktOsobe_kontaktOsobaid",
                        column: x => x.kontaktOsobaid,
                        principalTable: "KontaktOsobe",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DodatneInformacije",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pusac = table.Column<bool>(nullable: false),
                    dijabetes = table.Column<bool>(nullable: false),
                    plucnaOboljenja = table.Column<bool>(nullable: false),
                    srcanaOboljenja = table.Column<bool>(nullable: false),
                    Osobaid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DodatneInformacije", x => x.id);
                    table.ForeignKey(
                        name: "FK_DodatneInformacije_Osobe_Osobaid",
                        column: x => x.Osobaid,
                        principalTable: "Osobe",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Simptomi",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    temperatura = table.Column<bool>(nullable: false),
                    umor = table.Column<bool>(nullable: false),
                    suhiKasalj = table.Column<bool>(nullable: false),
                    teskocaDisanja = table.Column<bool>(nullable: false),
                    grlobolja = table.Column<bool>(nullable: false),
                    proljev = table.Column<bool>(nullable: false),
                    bolovi = table.Column<bool>(nullable: false),
                    zacepljenjeNosa = table.Column<bool>(nullable: false),
                    curenjeNosa = table.Column<bool>(nullable: false),
                    blagiSimptomi = table.Column<bool>(nullable: false),
                    srednjiJakiSimptomi = table.Column<bool>(nullable: false),
                    veomaSlabiSimtomi = table.Column<bool>(nullable: false),
                    jakiSimptomi = table.Column<bool>(nullable: false),
                    kontaktSaZarazenomOsobom = table.Column<bool>(nullable: false),
                    Osobaid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Simptomi", x => x.id);
                    table.ForeignKey(
                        name: "FK_Simptomi_Osobe_Osobaid",
                        column: x => x.Osobaid,
                        principalTable: "Osobe",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DodatneInformacije_Osobaid",
                table: "DodatneInformacije",
                column: "Osobaid");

            migrationBuilder.CreateIndex(
                name: "IX_Osobe_kontaktOsobaid",
                table: "Osobe",
                column: "kontaktOsobaid");

            migrationBuilder.CreateIndex(
                name: "IX_Simptomi_Osobaid",
                table: "Simptomi",
                column: "Osobaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DodatneInformacije");

            migrationBuilder.DropTable(
                name: "Simptomi");

            migrationBuilder.DropTable(
                name: "Osobe");

            migrationBuilder.DropTable(
                name: "KontaktOsobe");
        }
    }
}
