using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Access_Layer.Migrations
{
    /// <inheritdoc />
    public partial class dbolustur : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AkilliKlimalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EnerjiSinifi = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Fiyat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Code = table.Column<int>(type: "int", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkilliKlimalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AkilliPerdeler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    En = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Boy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KaplamaMaddesi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fiyat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Code = table.Column<int>(type: "int", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkilliPerdeler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Konut",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KonutTip = table.Column<byte>(type: "tinyint", maxLength: 3, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Code = table.Column<int>(type: "int", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konut", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AkilliKlimaKonut",
                columns: table => new
                {
                    AkilliKlimalarId = table.Column<int>(type: "int", nullable: false),
                    KonutlarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkilliKlimaKonut", x => new { x.AkilliKlimalarId, x.KonutlarId });
                    table.ForeignKey(
                        name: "FK_AkilliKlimaKonut_AkilliKlimalar_AkilliKlimalarId",
                        column: x => x.AkilliKlimalarId,
                        principalTable: "AkilliKlimalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkilliKlimaKonut_Konut_KonutlarId",
                        column: x => x.KonutlarId,
                        principalTable: "Konut",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AkilliPerdeKonut",
                columns: table => new
                {
                    AkilliPerdelerId = table.Column<int>(type: "int", nullable: false),
                    KonutlarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkilliPerdeKonut", x => new { x.AkilliPerdelerId, x.KonutlarId });
                    table.ForeignKey(
                        name: "FK_AkilliPerdeKonut_AkilliPerdeler_AkilliPerdelerId",
                        column: x => x.AkilliPerdelerId,
                        principalTable: "AkilliPerdeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkilliPerdeKonut_Konut_KonutlarId",
                        column: x => x.KonutlarId,
                        principalTable: "Konut",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AkilliKlimaKonut_KonutlarId",
                table: "AkilliKlimaKonut",
                column: "KonutlarId");

            migrationBuilder.CreateIndex(
                name: "IX_AkilliPerdeKonut_KonutlarId",
                table: "AkilliPerdeKonut",
                column: "KonutlarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AkilliKlimaKonut");

            migrationBuilder.DropTable(
                name: "AkilliPerdeKonut");

            migrationBuilder.DropTable(
                name: "AkilliKlimalar");

            migrationBuilder.DropTable(
                name: "AkilliPerdeler");

            migrationBuilder.DropTable(
                name: "Konut");
        }
    }
}
