using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KutuphaneMVC2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adminler",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KullaniciAdi = table.Column<string>(type: "TEXT", nullable: false),
                    Ad = table.Column<string>(type: "TEXT", nullable: false),
                    Soyad = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Sifre = table.Column<string>(type: "TEXT", nullable: false),
                    SonGirisTarihi = table.Column<DateTime>(type: "TEXT", nullable: true),
                    YetkiSeviyesi = table.Column<string>(type: "TEXT", nullable: false),
                    AktifMi = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adminler", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    KitapId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KitapAdi = table.Column<string>(type: "TEXT", nullable: false),
                    Yazar = table.Column<string>(type: "TEXT", nullable: false),
                    YayinEvi = table.Column<string>(type: "TEXT", nullable: false),
                    BasimYili = table.Column<int>(type: "INTEGER", nullable: true),
                    SayfaSayisi = table.Column<int>(type: "INTEGER", nullable: false),
                    Kategori = table.Column<string>(type: "TEXT", nullable: false),
                    StokDurumu = table.Column<bool>(type: "INTEGER", nullable: false),
                    ISBN = table.Column<string>(type: "TEXT", nullable: false),
                    Aciklama = table.Column<string>(type: "TEXT", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.KitapId);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ad = table.Column<string>(type: "TEXT", nullable: false),
                    Soyad = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Sifre = table.Column<string>(type: "TEXT", nullable: false),
                    Telefon = table.Column<string>(type: "TEXT", nullable: false),
                    Adres = table.Column<string>(type: "TEXT", nullable: false),
                    UyelikTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AktifMi = table.Column<bool>(type: "INTEGER", nullable: false),
                    SonGirisTarihi = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.KullaniciId);
                });

            migrationBuilder.CreateTable(
                name: "KitapOdunc",
                columns: table => new
                {
                    OduncId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KitapId = table.Column<int>(type: "INTEGER", nullable: false),
                    KullaniciId = table.Column<int>(type: "INTEGER", nullable: false),
                    AlinmaTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IadeTarihi = table.Column<DateTime>(type: "TEXT", nullable: true),
                    BeklenenIadeTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Durum = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapOdunc", x => x.OduncId);
                    table.ForeignKey(
                        name: "FK_KitapOdunc_Kitaplar_KitapId",
                        column: x => x.KitapId,
                        principalTable: "Kitaplar",
                        principalColumn: "KitapId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitapOdunc_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "KullaniciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Adminler",
                columns: new[] { "AdminId", "Ad", "AktifMi", "Email", "KullaniciAdi", "Sifre", "SonGirisTarihi", "Soyad", "YetkiSeviyesi" },
                values: new object[] { 1, "Admin", true, "admin@kutuphane.com", "admin", "Admin123!", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", "SuperAdmin" });

            migrationBuilder.InsertData(
                table: "Kitaplar",
                columns: new[] { "KitapId", "Aciklama", "BasimYili", "EklenmeTarihi", "ISBN", "Kategori", "KitapAdi", "SayfaSayisi", "StokDurumu", "YayinEvi", "Yazar" },
                values: new object[,]
                {
                    { 1, "Klasik Rus edebiyatının başyapıtlarından biri", 2020, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "978-975-458-717-0", "Roman", "Suç ve Ceza", 704, true, "İş Bankası Kültür Yayınları", "Fyodor Dostoyevski" },
                    { 2, "Distopik edebiyatın en önemli eserlerinden biri", 2019, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "978-975-07-1029-4", "Distopik Roman", "1984", 352, true, "Can Yayınları", "George Orwell" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_KitapOdunc_KitapId",
                table: "KitapOdunc",
                column: "KitapId");

            migrationBuilder.CreateIndex(
                name: "IX_KitapOdunc_KullaniciId",
                table: "KitapOdunc",
                column: "KullaniciId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adminler");

            migrationBuilder.DropTable(
                name: "KitapOdunc");

            migrationBuilder.DropTable(
                name: "Kitaplar");

            migrationBuilder.DropTable(
                name: "Kullanicilar");
        }
    }
}
