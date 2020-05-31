using Scrumler.Entity.Base;
using System;

namespace Scrumler.Entity.Dto
{
    public class DtoYetki : DtoBase
    {
        public int YetkiID { get; set; }
        public string YetkiAdi { get; set; }
        public byte? ModulID { get; set; }
        public DateTime? KayitZamani { get; set; }
    }
}