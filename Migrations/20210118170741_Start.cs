using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektMS.Migrations
{
    public partial class Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cena",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cena1 = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cena", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Producent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: false),
                    Kraj = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tytul = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: false),
                    RokProdukcji = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KategoriaId = table.Column<int>(type: "int", nullable: false),
                    CenaId = table.Column<int>(type: "int", nullable: false),
                    Nowy = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gry_Cena_CenaId",
                        column: x => x.CenaId,
                        principalTable: "Cena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gry_Kategoria_KategoriaId",
                        column: x => x.KategoriaId,
                        principalTable: "Kategoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GryProducent",
                columns: table => new
                {
                    GryId = table.Column<int>(type: "int", nullable: false),
                    ProducentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GryProducent", x => new { x.GryId, x.ProducentId });
                    table.ForeignKey(
                        name: "FK_GryProducent_Gry_GryId",
                        column: x => x.GryId,
                        principalTable: "Gry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GryProducent_Producent_ProducentId",
                        column: x => x.ProducentId,
                        principalTable: "Producent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gry_CenaId",
                table: "Gry",
                column: "CenaId");

            migrationBuilder.CreateIndex(
                name: "IX_Gry_KategoriaId",
                table: "Gry",
                column: "KategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_GryProducent_ProducentId",
                table: "GryProducent",
                column: "ProducentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GryProducent");

            migrationBuilder.DropTable(
                name: "Gry");

            migrationBuilder.DropTable(
                name: "Producent");

            migrationBuilder.DropTable(
                name: "Cena");

            migrationBuilder.DropTable(
                name: "Kategoria");
        }
    }
}
