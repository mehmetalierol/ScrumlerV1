using Scrumler.Dal.Abstract.Repository;
using Scrumler.Dal.Concrete.EntityFramework;
using Scrumler.Entity.Dto;
using Scrumler.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Scrumler.Dal
{
    public class KullaniciRepository : GenericRepository<Kullanici>, IKullaniciRepository
    {
        public KullaniciRepository(DbContext context) : base(context)
        {
        }

        public Kullanici CheckUser(DtoLogin dtoLogin)
        {
            return _dbset.FirstOrDefault(x => x.KullaniciKodu == dtoLogin.Email && x.Parola == dtoLogin.Password);
        }
    }
}