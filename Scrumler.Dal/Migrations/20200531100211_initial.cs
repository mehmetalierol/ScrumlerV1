using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Scrumler.Dal.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(maxLength: 30, nullable: true),
                    KullaniciSoyadi = table.Column<string>(maxLength: 30, nullable: true),
                    KullaniciKodu = table.Column<string>(maxLength: 40, nullable: false),
                    Parola = table.Column<string>(maxLength: 20, nullable: false),
                    KayitZamani = table.Column<DateTime>(type: "datetime", nullable: true),
                    Aktif = table.Column<bool>(type: "bit", nullable: true),
                    IsyeriID = table.Column<int>(type: "int", nullable: true),
                    YetkiID = table.Column<byte>(type: "tinyint", nullable: false),
                    Sifre = table.Column<string>(maxLength: 128, nullable: true),
                    EnSonGirisZamani = table.Column<DateTime>(type: "datetime", nullable: true),
                    CepTelNo = table.Column<string>(maxLength: 15, nullable: true),
                    EMail = table.Column<string>(maxLength: 30, nullable: true),
                    CariGoruntulemeYetki = table.Column<bool>(type: "bit", nullable: true),
                    CariYeniYetki = table.Column<bool>(type: "bit", nullable: true),
                    CariDuzenleYetki = table.Column<bool>(type: "bit", nullable: true),
                    CariSilYetki = table.Column<bool>(type: "bit", nullable: true),
                    CariTahsilatYapYetki = table.Column<bool>(type: "bit", nullable: true),
                    CariOdemeYapYetki = table.Column<bool>(type: "bit", nullable: true),
                    CariAlacaklandirYetki = table.Column<bool>(type: "bit", nullable: true),
                    CariBorclandirYetki = table.Column<bool>(type: "bit", nullable: true),
                    CariIslemDuzenleYetki = table.Column<bool>(type: "bit", nullable: true),
                    CariIslemSilYetki = table.Column<bool>(type: "bit", nullable: true),
                    StokGoruntulemeYetki = table.Column<bool>(type: "bit", nullable: true),
                    StokYeniYetki = table.Column<bool>(type: "bit", nullable: true),
                    StokSilYetki = table.Column<bool>(type: "bit", nullable: true),
                    StokDuzenleYetki = table.Column<bool>(type: "bit", nullable: true),
                    StokGirisYetki = table.Column<bool>(type: "bit", nullable: true),
                    StokCikisYetki = table.Column<bool>(type: "bit", nullable: true),
                    StokDepodanAktarYetki = table.Column<bool>(type: "bit", nullable: true),
                    StokIslemSilYetki = table.Column<bool>(type: "bit", nullable: true),
                    StokIslemDuzenleYetki = table.Column<bool>(type: "bit", nullable: true),
                    StokHareketGoruntuleYetki = table.Column<bool>(type: "bit", nullable: true),
                    StokFiyatHareketiGoruntuleYetki = table.Column<bool>(type: "bit", nullable: true),
                    StokEtiketBasYetki = table.Column<bool>(type: "bit", nullable: true),
                    StokRafEtiketBasYetki = table.Column<bool>(type: "bit", nullable: true),
                    KasaGoruntulemeYetki = table.Column<bool>(type: "bit", nullable: true),
                    KasaGirisYapYetki = table.Column<bool>(type: "bit", nullable: true),
                    KasaCikisYapYetki = table.Column<bool>(type: "bit", nullable: true),
                    KasaIslemDuzeltYetki = table.Column<bool>(type: "bit", nullable: true),
                    KasaIslemSilYetki = table.Column<bool>(type: "bit", nullable: true),
                    BankaGoruntulemeYetki = table.Column<bool>(type: "bit", nullable: true),
                    BankaEkleYetki = table.Column<bool>(type: "bit", nullable: true),
                    BankaDuzenleYetki = table.Column<bool>(type: "bit", nullable: true),
                    BankaSilYetki = table.Column<bool>(type: "bit", nullable: true),
                    BankaGirisYapYetki = table.Column<bool>(type: "bit", nullable: true),
                    BankaCikisYapYetki = table.Column<bool>(type: "bit", nullable: true),
                    BankaIslemDuzenleYetki = table.Column<bool>(type: "bit", nullable: true),
                    BankaIslemSilYetki = table.Column<bool>(type: "bit", nullable: true),
                    KullaniciGoruntulemeYetki = table.Column<bool>(type: "bit", nullable: true),
                    KullaniciEkleYetki = table.Column<bool>(type: "bit", nullable: true),
                    KullaniciDuzenleYetki = table.Column<bool>(type: "bit", nullable: true),
                    KullaniciSilYetki = table.Column<bool>(type: "bit", nullable: true),
                    SirketBilgileriGoruntulemeYetki = table.Column<bool>(type: "bit", nullable: true),
                    AyarlarGoruntulemeYetki = table.Column<bool>(type: "bit", nullable: true),
                    BankaKasayaVirmanYetki = table.Column<bool>(type: "bit", nullable: true),
                    BankadanBankayaVirmanYetki = table.Column<bool>(type: "bit", nullable: true),
                    StokDepodanHizliAktarYetki = table.Column<bool>(type: "bit", nullable: true),
                    StokTopluFiyatGuncelleYetki = table.Column<bool>(type: "bit", nullable: true),
                    IrsaliyeGoruntulemeYetki = table.Column<bool>(type: "bit", nullable: false),
                    FaturaGoruntulemeYetki = table.Column<bool>(type: "bit", nullable: false),
                    CekSenetGoruntulemeYetki = table.Column<bool>(type: "bit", nullable: false),
                    TaksitGoruntulemeYetki = table.Column<bool>(type: "bit", nullable: false),
                    PersonelGoruntulemeYetki = table.Column<bool>(type: "bit", nullable: false),
                    HizliSatisGoruntulemeYetki = table.Column<bool>(type: "bit", nullable: false),
                    HizliYeniSatisFaturasiGoruntulemeYetki = table.Column<bool>(type: "bit", nullable: false),
                    HizliYeniAlisFaturasiGoruntulemeYetki = table.Column<bool>(type: "bit", nullable: false),
                    RutHareketPlaniYetki = table.Column<bool>(type: "bit", nullable: false),
                    RaporlariGoruntulemeYetki = table.Column<bool>(type: "bit", nullable: false),
                    TanimamalariGoruntulemeYetki = table.Column<bool>(type: "bit", nullable: false),
                    TCKimlikNo = table.Column<string>(maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.KullaniciID);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciYetki",
                columns: table => new
                {
                    KullaniciYetkiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YetkiID = table.Column<int>(type: "int", nullable: true),
                    KullaniciID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciYetki", x => x.KullaniciYetkiID);
                });

            migrationBuilder.CreateTable(
                name: "Yetki",
                columns: table => new
                {
                    YetkiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YetkiAdi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModulID = table.Column<byte>(type: "tinyint", nullable: true),
                    KayitZamani = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yetki", x => x.YetkiID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_KullaniciKodu_Parola",
                table: "Kullanici",
                columns: new[] { "KullaniciKodu", "Parola" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kullanici");

            migrationBuilder.DropTable(
                name: "KullaniciYetki");

            migrationBuilder.DropTable(
                name: "Yetki");
        }
    }
}
