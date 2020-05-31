using Scrumler.Entity.Dto;
using Scrumler.Entity.Models;
using Scrumler.Interface.Base;

namespace Scrumler.Bll.Abstract
{
    public interface IKullaniciBL : IBllBase<Kullanici, DtoKullanici>
    {
        DtoSession Login(DtoLogin dtoLogin);
    }
}