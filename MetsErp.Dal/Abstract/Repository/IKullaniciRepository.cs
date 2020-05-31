using Scrumler.Entity.Dto;
using Scrumler.Entity.Models;
using Scrumler.Interface.Base;

namespace Scrumler.Dal.Abstract.Repository
{
    public interface IKullaniciRepository : IGenericRepository<Kullanici>
    {
        Kullanici CheckUser(DtoLogin dtoLogin);
    }
}