using Scrumler.Entity.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scrumler.Entity.Models
{
    [Table("KullaniciYetki")]
    public class KullaniciYetki : EntityBase
    {
        [Key]
        [Column("KullaniciYetkiID", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Kullanici Yetki ID is required")]
        public int KullaniciYetkiID { get; set; } // int, not null

        [Column("YetkiID", TypeName = "int")]
        public int? YetkiID { get; set; } // int, null

        [Column("KullaniciID", TypeName = "int")]
        public int? KullaniciID { get; set; } // int, null
    }
}