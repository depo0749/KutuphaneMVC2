using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KutuphaneMVC2.Migrations
{
    /// <inheritdoc />
    public partial class AddOduncModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oduncler",
                columns: table => new
                {
                    OduncId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KitapId = table.Column<int>(type: "INTEGER", nullable: false),
                    KullaniciId = table.Column<int>(type: "INTEGER", nullable: false),
                    OduncAlmaTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IadeTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    GerceklesenIadeTarihi = table.Column<DateTime>(type: "TEXT", nullable: true),
                    TeslimEdildi = table.Column<bool>(type: "INTEGER", nullable: false),
                    Notlar = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oduncler", x => x.OduncId);
                    table.ForeignKey(
                        name: "FK_Oduncler_Kitaplar_KitapId",
                        column: x => x.KitapId,
                        principalTable: "Kitaplar",
                        principalColumn: "KitapId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Oduncler_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "KullaniciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Oduncler_KitapId",
                table: "Oduncler",
                column: "KitapId");

            migrationBuilder.CreateIndex(
                name: "IX_Oduncler_KullaniciId",
                table: "Oduncler",
                column: "KullaniciId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oduncler");
        }
    }
}
