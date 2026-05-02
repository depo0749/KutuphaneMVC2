using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KutuphaneMVC2.Migrations
{
    /// <inheritdoc />
    public partial class AddSampleUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "KullaniciId", "Ad", "Adres", "AktifMi", "Email", "Sifre", "SonGirisTarihi", "Soyad", "Telefon", "UyelikTarihi" },
                values: new object[] { 1, "Ahmet", "İstanbul, Türkiye", true, "ahmet@example.com", "Kullanici123!", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yılmaz", "5551234567", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciId",
                keyValue: 1);
        }
    }
}
