using Scrumler.Entity.Base;
using System.Collections.Generic;

namespace Scrumler.Entity.Dto
{
    public class DtoSession : DtoBase
    {
        public DtoSession()
        {
            KullaniciYetkileri = new List<DtoKullaniciYetki>();
        }

        public DtoKullanici KullaniciBilgileri { get; set; }
        public List<DtoKullaniciYetki> KullaniciYetkileri { get; set; }
    }
}