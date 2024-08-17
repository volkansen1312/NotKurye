using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotKurye.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Akademisyenler",
                columns: table => new
                {
                    AkademikPersonelKimlikNo = table.Column<long>(type: "bigint", nullable: false),
                    Parola = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<long>(type: "bigint", nullable: false),
                    MailAdres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Akademisyenler", x => x.AkademikPersonelKimlikNo);
                });

            migrationBuilder.CreateTable(
                name: "MailIcerikleri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgrenciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgrenciSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DersAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SinavTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgrenciMailHesabi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Not = table.Column<int>(type: "int", nullable: false),
                    Mesaj = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailIcerikleri", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    OgrenciNo = table.Column<long>(type: "bigint", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<long>(type: "bigint", nullable: false),
                    MailAdres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.OgrenciNo);
                });

            migrationBuilder.CreateTable(
                name: "Dersler",
                columns: table => new
                {
                    DersKodu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DersAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kredi = table.Column<int>(type: "int", nullable: false),
                    Acts = table.Column<int>(type: "int", nullable: false),
                    AkademisyenAkademikPersonelKimlikNo = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dersler", x => x.DersKodu);
                    table.ForeignKey(
                        name: "FK_Dersler_Akademisyenler_AkademisyenAkademikPersonelKimlikNo",
                        column: x => x.AkademisyenAkademikPersonelKimlikNo,
                        principalTable: "Akademisyenler",
                        principalColumn: "AkademikPersonelKimlikNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DersOgrenci",
                columns: table => new
                {
                    DerslerDersKodu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OgrencilerOgrenciNo = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersOgrenci", x => new { x.DerslerDersKodu, x.OgrencilerOgrenciNo });
                    table.ForeignKey(
                        name: "FK_DersOgrenci_Dersler_DerslerDersKodu",
                        column: x => x.DerslerDersKodu,
                        principalTable: "Dersler",
                        principalColumn: "DersKodu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DersOgrenci_Ogrenciler_OgrencilerOgrenciNo",
                        column: x => x.OgrencilerOgrenciNo,
                        principalTable: "Ogrenciler",
                        principalColumn: "OgrenciNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dersler_AkademisyenAkademikPersonelKimlikNo",
                table: "Dersler",
                column: "AkademisyenAkademikPersonelKimlikNo");

            migrationBuilder.CreateIndex(
                name: "IX_DersOgrenci_OgrencilerOgrenciNo",
                table: "DersOgrenci",
                column: "OgrencilerOgrenciNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DersOgrenci");

            migrationBuilder.DropTable(
                name: "MailIcerikleri");

            migrationBuilder.DropTable(
                name: "Dersler");

            migrationBuilder.DropTable(
                name: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "Akademisyenler");
        }
    }
}
