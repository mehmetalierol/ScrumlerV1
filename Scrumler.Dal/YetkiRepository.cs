using Scrumler.Dal.Abstract.Repository;
using Scrumler.Dal.Concrete.EntityFramework;
using Scrumler.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Scrumler.Dal
{
    public class YetkiRepository : GenericRepository<Yetki>, IYetkiRepository
    {
        public YetkiRepository(DbContext context) : base(context)
        {
        }
    }
}