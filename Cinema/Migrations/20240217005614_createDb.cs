using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinema.Migrations
{
    /// <inheritdoc />
    public partial class createDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aktorler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aktorler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filmler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sure = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salonlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalonAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kapasite = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salonlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seanslar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeansSaat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seanslar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tarihler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GosterimTarihi = table.Column<DateOnly>(type: "date", nullable: false),
                    VizyonaGirisTarihi = table.Column<DateOnly>(type: "date", nullable: false),
                    VizyondanCikisTarihi = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarihler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yonetmenler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yonetmenler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AktorFilm",
                columns: table => new
                {
                    AktorlerId = table.Column<int>(type: "int", nullable: false),
                    FilmlerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AktorFilm", x => new { x.AktorlerId, x.FilmlerId });
                    table.ForeignKey(
                        name: "FK_AktorFilm_Aktorler_AktorlerId",
                        column: x => x.AktorlerId,
                        principalTable: "Aktorler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AktorFilm_Filmler_FilmlerId",
                        column: x => x.FilmlerId,
                        principalTable: "Filmler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmKategori",
                columns: table => new
                {
                    FilmlerId = table.Column<int>(type: "int", nullable: false),
                    KategorilerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmKategori", x => new { x.FilmlerId, x.KategorilerId });
                    table.ForeignKey(
                        name: "FK_FilmKategori_Filmler_FilmlerId",
                        column: x => x.FilmlerId,
                        principalTable: "Filmler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmKategori_Kategoriler_KategorilerId",
                        column: x => x.KategorilerId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Biletler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    SalonId = table.Column<int>(type: "int", nullable: false),
                    SenasId = table.Column<int>(type: "int", nullable: false),
                    SeansId = table.Column<int>(type: "int", nullable: false),
                    TarihId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biletler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Biletler_Filmler_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Filmler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Biletler_Salonlar_SalonId",
                        column: x => x.SalonId,
                        principalTable: "Salonlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Biletler_Seanslar_SeansId",
                        column: x => x.SeansId,
                        principalTable: "Seanslar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Biletler_Tarihler_TarihId",
                        column: x => x.TarihId,
                        principalTable: "Tarihler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmYonetmen",
                columns: table => new
                {
                    FilmlerId = table.Column<int>(type: "int", nullable: false),
                    YonetmenlerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmYonetmen", x => new { x.FilmlerId, x.YonetmenlerId });
                    table.ForeignKey(
                        name: "FK_FilmYonetmen_Filmler_FilmlerId",
                        column: x => x.FilmlerId,
                        principalTable: "Filmler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmYonetmen_Yonetmenler_YonetmenlerId",
                        column: x => x.YonetmenlerId,
                        principalTable: "Yonetmenler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AktorFilm_FilmlerId",
                table: "AktorFilm",
                column: "FilmlerId");

            migrationBuilder.CreateIndex(
                name: "IX_Biletler_FilmId",
                table: "Biletler",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Biletler_SalonId",
                table: "Biletler",
                column: "SalonId");

            migrationBuilder.CreateIndex(
                name: "IX_Biletler_SeansId",
                table: "Biletler",
                column: "SeansId");

            migrationBuilder.CreateIndex(
                name: "IX_Biletler_TarihId",
                table: "Biletler",
                column: "TarihId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmKategori_KategorilerId",
                table: "FilmKategori",
                column: "KategorilerId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmYonetmen_YonetmenlerId",
                table: "FilmYonetmen",
                column: "YonetmenlerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AktorFilm");

            migrationBuilder.DropTable(
                name: "Biletler");

            migrationBuilder.DropTable(
                name: "FilmKategori");

            migrationBuilder.DropTable(
                name: "FilmYonetmen");

            migrationBuilder.DropTable(
                name: "Aktorler");

            migrationBuilder.DropTable(
                name: "Salonlar");

            migrationBuilder.DropTable(
                name: "Seanslar");

            migrationBuilder.DropTable(
                name: "Tarihler");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Filmler");

            migrationBuilder.DropTable(
                name: "Yonetmenler");
        }
    }
}
