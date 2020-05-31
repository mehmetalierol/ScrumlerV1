using Scrumler.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scrumler.Entity.Models
{
    [Table("Yetki")]
    public class Yetki : EntityBase
    {
        [Key]
        [Column("YetkiID", TypeName = "int")]
        [Required(ErrorMessage = "Yetki ID is required")]
        public int YetkiID { get; set; } // int, not null

        [Column("YetkiAdi", TypeName = "nvarchar(200)")]
        [MaxLength(200)]
        [StringLength(200)]
        public string YetkiAdi { get; set; } // nvarchar(200), null

        [Column("ModulID", TypeName = "tinyint")]
        public byte? ModulID { get; set; } // tinyint, null

        [Column("KayitZamani", TypeName = "datetime")]
        public DateTime? KayitZamani { get; set; } // datetime, null
    }
}