using Scrumler.Dal.Abstract.Repository;
using Scrumler.Dal.Concrete.EntityFramework;
using Scrumler.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Scrumler.Dal
{
    public class KullaniciYetkiRepository : GenericRepository<KullaniciYetki>, IKullaniciYetkiRepository
    {
        public KullaniciYetkiRepository(DbContext context) : base(context)
        {
        }

        public List<KullaniciYetki> GetUserPermissios(int userId)
        {
            return _dbset.Where(x => x.KullaniciID == userId).ToList();
        }
    }
}