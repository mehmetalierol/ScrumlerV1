using Scrumler.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scrumler.Entity.Models
{
    [Table("Kullanici")]
    public class Kullanici : EntityBase
    {
        [Key]
        [Column("KullaniciID", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Kullanici ID is required")]
        public int KullaniciID { get; set; } // int, not null

        [Column("KullaniciAdi")]
        [MaxLength(30)]
        [StringLength(30)]
        public string KullaniciAdi { get; set; } // nvarchar(30), null

        [Column("KullaniciSoyadi")]
        [MaxLength(30)]
        [StringLength(30)]
        public string KullaniciSoyadi { get; set; } // nvarchar(30), null

        [Column("KullaniciKodu")]
        [MaxLength(40)]
        [StringLength(40)]
        [Required(ErrorMessage = "Kullanici Kodu is required")]
        public string KullaniciKodu { get; set; } // nvarchar(40), not null

        [Column("Parola")]
        [MaxLength(20)]
        [StringLength(20)]
        [Required(ErrorMessage = "Parola is required")]
        public string Parola { get; set; } // nvarchar(20), not null

        [Column("KayitZamani", TypeName = "datetime")]
        public DateTime? KayitZamani { get; set; } // datetime, null

        [Column("Aktif", TypeName = "bit")]
        public bool? Aktif { get; set; } // bit, null

        [Column("IsyeriID", TypeName = "int")]
        public int? IsyeriID { get; set; } // int, null

        [Column("YetkiID", TypeName = "tinyint")]
        [Required(ErrorMessage = "Yetki ID is required")]
        public byte YetkiID { get; set; } // tinyint, not null

        [Column("Sifre")]
        [MaxLength(128)]
        [StringLength(128)]
        public string Sifre { get; set; } // nvarchar(128), null

        [Column("EnSonGirisZamani", TypeName = "datetime")]
        public DateTime? EnSonGirisZamani { get; set; } // datetime, null

        [Column("CepTelNo")]
        [MaxLength(15)]
        [StringLength(15)]
        public string CepTelNo { get; set; } // varchar(15), null

        [Column("EMail")]
        [MaxLength(30)]
        [StringLength(30)]
        public string EMail { get; set; } // varchar(30), null

        [Column("CariGoruntulemeYetki", TypeName = "bit")]
        public bool? CariGoruntulemeYetki { get; set; } // bit, null

        [Column("CariYeniYetki", TypeName = "bit")]
        public bool? CariYeniYetki { get; set; } // bit, null

        [Column("CariDuzenleYetki", TypeName = "bit")]
        public bool? CariDuzenleYetki { get; set; } // bit, null

        [Column("CariSilYetki", TypeName = "bit")]
        public bool? CariSilYetki { get; set; } // bit, null

        [Column("CariTahsilatYapYetki", TypeName = "bit")]
        public bool? CariTahsilatYapYetki { get; set; } // bit, null

        [Column("CariOdemeYapYetki", TypeName = "bit")]
        public bool? CariOdemeYapYetki { get; set; } // bit, null

        [Column("CariAlacaklandirYetki", TypeName = "bit")]
        public bool? CariAlacaklandirYetki { get; set; } // bit, null

        [Column("CariBorclandirYetki", TypeName = "bit")]
        public bool? CariBorclandirYetki { get; set; } // bit, null

        [Column("CariIslemDuzenleYetki", TypeName = "bit")]
        public bool? CariIslemDuzenleYetki { get; set; } // bit, null

        [Column("CariIslemSilYetki", TypeName = "bit")]
        public bool? CariIslemSilYetki { get; set; } // bit, null

        [Column("StokGoruntulemeYetki", TypeName = "bit")]
        public bool? StokGoruntulemeYetki { get; set; } // bit, null

        [Column("StokYeniYetki", TypeName = "bit")]
        public bool? StokYeniYetki { get; set; } // bit, null

        [Column("StokSilYetki", TypeName = "bit")]
        public bool? StokSilYetki { get; set; } // bit, null

        [Column("StokDuzenleYetki", TypeName = "bit")]
        public bool? StokDuzenleYetki { get; set; } // bit, null

        [Column("StokGirisYetki", TypeName = "bit")]
        public bool? StokGirisYetki { get; set; } // bit, null

        [Column("StokCikisYetki", TypeName = "bit")]
        public bool? StokCikisYetki { get; set; } // bit, null

        [Column("StokDepodanAktarYetki", TypeName = "bit")]
        public bool? StokDepodanAktarYetki { get; set; } // bit, null

        [Column("StokIslemSilYetki", TypeName = "bit")]
        public bool? StokIslemSilYetki { get; set; } // bit, null

        [Column("StokIslemDuzenleYetki", TypeName = "bit")]
        public bool? StokIslemDuzenleYetki { get; set; } // bit, null

        [Column("StokHareketGoruntuleYetki", TypeName = "bit")]
        public bool? StokHareketGoruntuleYetki { get; set; } // bit, null

        [Column("StokFiyatHareketiGoruntuleYetki", TypeName = "bit")]
        public bool? StokFiyatHareketiGoruntuleYetki { get; set; } // bit, null

        [Column("StokEtiketBasYetki", TypeName = "bit")]
        public bool? StokEtiketBasYetki { get; set; } // bit, null

        [Column("StokRafEtiketBasYetki", TypeName = "bit")]
        public bool? StokRafEtiketBasYetki { get; set; } // bit, null

        [Column("KasaGoruntulemeYetki", TypeName = "bit")]
        public bool? KasaGoruntulemeYetki { get; set; } // bit, null

        [Column("KasaGirisYapYetki", TypeName = "bit")]
        public bool? KasaGirisYapYetki { get; set; } // bit, null

        [Column("KasaCikisYapYetki", TypeName = "bit")]
        public bool? KasaCikisYapYetki { get; set; } // bit, null

        [Column("KasaIslemDuzeltYetki", TypeName = "bit")]
        public bool? KasaIslemDuzeltYetki { get; set; } // bit, null

        [Column("KasaIslemSilYetki", TypeName = "bit")]
        public bool? KasaIslemSilYetki { get; set; } // bit, null

        [Column("BankaGoruntulemeYetki", TypeName = "bit")]
        public bool? BankaGoruntulemeYetki { get; set; } // bit, null

        [Column("BankaEkleYetki", TypeName = "bit")]
        public bool? BankaEkleYetki { get; set; } // bit, null

        [Column("BankaDuzenleYetki", TypeName = "bit")]
        public bool? BankaDuzenleYetki { get; set; } // bit, null

        [Column("BankaSilYetki", TypeName = "bit")]
        public bool? BankaSilYetki { get; set; } // bit, null

        [Column("BankaGirisYapYetki", TypeName = "bit")]
        public bool? BankaGirisYapYetki { get; set; } // bit, null

        [Column("BankaCikisYapYetki", TypeName = "bit")]
        public bool? BankaCikisYapYetki { get; set; } // bit, null

        [Column("BankaIslemDuzenleYetki", TypeName = "bit")]
        public bool? BankaIslemDuzenleYetki { get; set; } // bit, null

        [Column("BankaIslemSilYetki", TypeName = "bit")]
        public bool? BankaIslemSilYetki { get; set; } // bit, null

        [Column("KullaniciGoruntulemeYetki", TypeName = "bit")]
        public bool? KullaniciGoruntulemeYetki { get; set; } // bit, null

        [Column("KullaniciEkleYetki", TypeName = "bit")]
        public bool? KullaniciEkleYetki { get; set; } // bit, null

        [Column("KullaniciDuzenleYetki", TypeName = "bit")]
        public bool? KullaniciDuzenleYetki { get; set; } // bit, null

        [Column("KullaniciSilYetki", TypeName = "bit")]
        public bool? KullaniciSilYetki { get; set; } // bit, null

        [Column("SirketBilgileriGoruntulemeYetki", TypeName = "bit")]
        public bool? SirketBilgileriGoruntulemeYetki { get; set; } // bit, null

        [Column("AyarlarGoruntulemeYetki", TypeName = "bit")]
        public bool? AyarlarGoruntulemeYetki { get; set; } // bit, null

        [Column("BankaKasayaVirmanYetki", TypeName = "bit")]
        public bool? BankaKasayaVirmanYetki { get; set; } // bit, null

        [Column("BankadanBankayaVirmanYetki", TypeName = "bit")]
        public bool? BankadanBankayaVirmanYetki { get; set; } // bit, null

        [Column("StokDepodanHizliAktarYetki", TypeName = "bit")]
        public bool? StokDepodanHizliAktarYetki { get; set; } // bit, null

        [Column("StokTopluFiyatGuncelleYetki", TypeName = "bit")]
        public bool? StokTopluFiyatGuncelleYetki { get; set; } // bit, null

        [Column("IrsaliyeGoruntulemeYetki", TypeName = "bit")]
        [Required(ErrorMessage = "Irsaliye Goruntuleme Yetki is required")]
        public bool IrsaliyeGoruntulemeYetki { get; set; } // bit, not null

        [Column("FaturaGoruntulemeYetki", TypeName = "bit")]
        [Required(ErrorMessage = "Fatura Goruntuleme Yetki is required")]
        public bool FaturaGoruntulemeYetki { get; set; } // bit, not null

        [Column("CekSenetGoruntulemeYetki", TypeName = "bit")]
        [Required(ErrorMessage = "Cek Senet Goruntuleme Yetki is required")]
        public bool CekSenetGoruntulemeYetki { get; set; } // bit, not null

        [Column("TaksitGoruntulemeYetki", TypeName = "bit")]
        [Required(ErrorMessage = "Taksit Goruntuleme Yetki is required")]
        public bool TaksitGoruntulemeYetki { get; set; } // bit, not null

        [Column("PersonelGoruntulemeYetki", TypeName = "bit")]
        [Required(ErrorMessage = "Personel Goruntuleme Yetki is required")]
        public bool PersonelGoruntulemeYetki { get; set; } // bit, not null

        [Column("HizliSatisGoruntulemeYetki", TypeName = "bit")]
        [Required(ErrorMessage = "Hizli Satis Goruntuleme Yetki is required")]
        public bool HizliSatisGoruntulemeYetki { get; set; } // bit, not null

        [Column("HizliYeniSatisFaturasiGoruntulemeYetki", TypeName = "bit")]
        [Required(ErrorMessage = "Hizli Yeni Satis Faturasi Goruntuleme Yetki is required")]
        public bool HizliYeniSatisFaturasiGoruntulemeYetki { get; set; } // bit, not null

        [Column("HizliYeniAlisFaturasiGoruntulemeYetki", TypeName = "bit")]
        [Required(ErrorMessage = "Hizli Yeni Alis Faturasi Goruntuleme Yetki is required")]
        public bool HizliYeniAlisFaturasiGoruntulemeYetki { get; set; } // bit, not null

        [Column("RutHareketPlaniYetki", TypeName = "bit")]
        [Required(ErrorMessage = "Rut Hareket Plani Yetki is required")]
        public bool RutHareketPlaniYetki { get; set; } // bit, not null

        [Column("RaporlariGoruntulemeYetki", TypeName = "bit")]
        [Required(ErrorMessage = "Raporlari Goruntuleme Yetki is required")]
        public bool RaporlariGoruntulemeYetki { get; set; } // bit, not null

        [Column("TanimamalariGoruntulemeYetki", TypeName = "bit")]
        [Required(ErrorMessage = "Tanimamalari Goruntuleme Yetki is required")]
        public bool TanimamalariGoruntulemeYetki { get; set; } // bit, not null

        [Column("TCKimlikNo")]
        [MaxLength(11)]
        [StringLength(11)]
        public string TCKimlikNo { get; set; } // varchar(11), null
    }
}