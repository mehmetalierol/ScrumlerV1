﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Scrumler.Dal.Concrete.EntityFramework;

namespace Scrumler.Dal.Migrations
{
    [DbContext(typeof(ScrumlerContext))]
    [Migration("20200531100211_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Scrumler.Entity.Models.Kullanici", b =>
                {
                    b.Property<int>("KullaniciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KullaniciID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Aktif")
                        .HasColumnName("Aktif")
                        .HasColumnType("bit");

                    b.Property<bool?>("AyarlarGoruntulemeYetki")
                        .HasColumnName("AyarlarGoruntulemeYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("BankaCikisYapYetki")
                        .HasColumnName("BankaCikisYapYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("BankaDuzenleYetki")
                        .HasColumnName("BankaDuzenleYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("BankaEkleYetki")
                        .HasColumnName("BankaEkleYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("BankaGirisYapYetki")
                        .HasColumnName("BankaGirisYapYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("BankaGoruntulemeYetki")
                        .HasColumnName("BankaGoruntulemeYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("BankaIslemDuzenleYetki")
                        .HasColumnName("BankaIslemDuzenleYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("BankaIslemSilYetki")
                        .HasColumnName("BankaIslemSilYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("BankaKasayaVirmanYetki")
                        .HasColumnName("BankaKasayaVirmanYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("BankaSilYetki")
                        .HasColumnName("BankaSilYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("BankadanBankayaVirmanYetki")
                        .HasColumnName("BankadanBankayaVirmanYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("CariAlacaklandirYetki")
                        .HasColumnName("CariAlacaklandirYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("CariBorclandirYetki")
                        .HasColumnName("CariBorclandirYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("CariDuzenleYetki")
                        .HasColumnName("CariDuzenleYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("CariGoruntulemeYetki")
                        .HasColumnName("CariGoruntulemeYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("CariIslemDuzenleYetki")
                        .HasColumnName("CariIslemDuzenleYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("CariIslemSilYetki")
                        .HasColumnName("CariIslemSilYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("CariOdemeYapYetki")
                        .HasColumnName("CariOdemeYapYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("CariSilYetki")
                        .HasColumnName("CariSilYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("CariTahsilatYapYetki")
                        .HasColumnName("CariTahsilatYapYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("CariYeniYetki")
                        .HasColumnName("CariYeniYetki")
                        .HasColumnType("bit");

                    b.Property<bool>("CekSenetGoruntulemeYetki")
                        .HasColumnName("CekSenetGoruntulemeYetki")
                        .HasColumnType("bit");

                    b.Property<string>("CepTelNo")
                        .HasColumnName("CepTelNo")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("EMail")
                        .HasColumnName("EMail")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("EnSonGirisZamani")
                        .HasColumnName("EnSonGirisZamani")
                        .HasColumnType("datetime");

                    b.Property<bool>("FaturaGoruntulemeYetki")
                        .HasColumnName("FaturaGoruntulemeYetki")
                        .HasColumnType("bit");

                    b.Property<bool>("HizliSatisGoruntulemeYetki")
                        .HasColumnName("HizliSatisGoruntulemeYetki")
                        .HasColumnType("bit");

                    b.Property<bool>("HizliYeniAlisFaturasiGoruntulemeYetki")
                        .HasColumnName("HizliYeniAlisFaturasiGoruntulemeYetki")
                        .HasColumnType("bit");

                    b.Property<bool>("HizliYeniSatisFaturasiGoruntulemeYetki")
                        .HasColumnName("HizliYeniSatisFaturasiGoruntulemeYetki")
                        .HasColumnType("bit");

                    b.Property<bool>("IrsaliyeGoruntulemeYetki")
                        .HasColumnName("IrsaliyeGoruntulemeYetki")
                        .HasColumnType("bit");

                    b.Property<int?>("IsyeriID")
                        .HasColumnName("IsyeriID")
                        .HasColumnType("int");

                    b.Property<bool?>("KasaCikisYapYetki")
                        .HasColumnName("KasaCikisYapYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("KasaGirisYapYetki")
                        .HasColumnName("KasaGirisYapYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("KasaGoruntulemeYetki")
                        .HasColumnName("KasaGoruntulemeYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("KasaIslemDuzeltYetki")
                        .HasColumnName("KasaIslemDuzeltYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("KasaIslemSilYetki")
                        .HasColumnName("KasaIslemSilYetki")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("KayitZamani")
                        .HasColumnName("KayitZamani")
                        .HasColumnType("datetime");

                    b.Property<string>("KullaniciAdi")
                        .HasColumnName("KullaniciAdi")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<bool?>("KullaniciDuzenleYetki")
                        .HasColumnName("KullaniciDuzenleYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("KullaniciEkleYetki")
                        .HasColumnName("KullaniciEkleYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("KullaniciGoruntulemeYetki")
                        .HasColumnName("KullaniciGoruntulemeYetki")
                        .HasColumnType("bit");

                    b.Property<string>("KullaniciKodu")
                        .IsRequired()
                        .HasColumnName("KullaniciKodu")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<bool?>("KullaniciSilYetki")
                        .HasColumnName("KullaniciSilYetki")
                        .HasColumnType("bit");

                    b.Property<string>("KullaniciSoyadi")
                        .HasColumnName("KullaniciSoyadi")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Parola")
                        .IsRequired()
                        .HasColumnName("Parola")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<bool>("PersonelGoruntulemeYetki")
                        .HasColumnName("PersonelGoruntulemeYetki")
                        .HasColumnType("bit");

                    b.Property<bool>("RaporlariGoruntulemeYetki")
                        .HasColumnName("RaporlariGoruntulemeYetki")
                        .HasColumnType("bit");

                    b.Property<bool>("RutHareketPlaniYetki")
                        .HasColumnName("RutHareketPlaniYetki")
                        .HasColumnType("bit");

                    b.Property<string>("Sifre")
                        .HasColumnName("Sifre")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<bool?>("SirketBilgileriGoruntulemeYetki")
                        .HasColumnName("SirketBilgileriGoruntulemeYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("StokCikisYetki")
                        .HasColumnName("StokCikisYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("StokDepodanAktarYetki")
                        .HasColumnName("StokDepodanAktarYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("StokDepodanHizliAktarYetki")
                        .HasColumnName("StokDepodanHizliAktarYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("StokDuzenleYetki")
                        .HasColumnName("StokDuzenleYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("StokEtiketBasYetki")
                        .HasColumnName("StokEtiketBasYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("StokFiyatHareketiGoruntuleYetki")
                        .HasColumnName("StokFiyatHareketiGoruntuleYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("StokGirisYetki")
                        .HasColumnName("StokGirisYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("StokGoruntulemeYetki")
                        .HasColumnName("StokGoruntulemeYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("StokHareketGoruntuleYetki")
                        .HasColumnName("StokHareketGoruntuleYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("StokIslemDuzenleYetki")
                        .HasColumnName("StokIslemDuzenleYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("StokIslemSilYetki")
                        .HasColumnName("StokIslemSilYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("StokRafEtiketBasYetki")
                        .HasColumnName("StokRafEtiketBasYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("StokSilYetki")
                        .HasColumnName("StokSilYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("StokTopluFiyatGuncelleYetki")
                        .HasColumnName("StokTopluFiyatGuncelleYetki")
                        .HasColumnType("bit");

                    b.Property<bool?>("StokYeniYetki")
                        .HasColumnName("StokYeniYetki")
                        .HasColumnType("bit");

                    b.Property<string>("TCKimlikNo")
                        .HasColumnName("TCKimlikNo")
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<bool>("TaksitGoruntulemeYetki")
                        .HasColumnName("TaksitGoruntulemeYetki")
                        .HasColumnType("bit");

                    b.Property<bool>("TanimamalariGoruntulemeYetki")
                        .HasColumnName("TanimamalariGoruntulemeYetki")
                        .HasColumnType("bit");

                    b.Property<byte>("YetkiID")
                        .HasColumnName("YetkiID")
                        .HasColumnType("tinyint");

                    b.HasKey("KullaniciID");

                    b.HasIndex("KullaniciKodu", "Parola");

                    b.ToTable("Kullanici");
                });

            modelBuilder.Entity("Scrumler.Entity.Models.KullaniciYetki", b =>
                {
                    b.Property<int>("KullaniciYetkiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KullaniciYetkiID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KullaniciID")
                        .HasColumnName("KullaniciID")
                        .HasColumnType("int");

                    b.Property<int?>("YetkiID")
                        .HasColumnName("YetkiID")
                        .HasColumnType("int");

                    b.HasKey("KullaniciYetkiID");

                    b.ToTable("KullaniciYetki");
                });

            modelBuilder.Entity("Scrumler.Entity.Models.Yetki", b =>
                {
                    b.Property<int>("YetkiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("YetkiID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("KayitZamani")
                        .HasColumnName("KayitZamani")
                        .HasColumnType("datetime");

                    b.Property<byte?>("ModulID")
                        .HasColumnName("ModulID")
                        .HasColumnType("tinyint");

                    b.Property<string>("YetkiAdi")
                        .HasColumnName("YetkiAdi")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("YetkiID");

                    b.ToTable("Yetki");
                });
#pragma warning restore 612, 618
        }
    }
}
