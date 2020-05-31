using Scrumler.Entity.Models;
using Scrumler.Interface.Base;
using System.Collections.Generic;

namespace Scrumler.Dal.Abstract.Repository
{
    public interface IKullaniciYetkiRepository : IGenericRepository<KullaniciYetki>
    {
        List<KullaniciYetki> GetUserPermissios(int userId);
    }
}