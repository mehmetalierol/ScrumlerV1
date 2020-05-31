using Scrumler.Entity.Base;

namespace Scrumler.Entity.Dto
{
    public class DtoKullaniciYetki : DtoBase
    {
        public int KullaniciYetkiID { get; set; }
        public int? YetkiID { get; set; }
        public int? KullaniciID { get; set; }
    }
}