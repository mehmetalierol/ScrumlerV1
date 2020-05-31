using AutoMapper;
using Scrumler.Bll.Abstract;
using Scrumler.Bll.Base;
using Scrumler.Dal.Abstract.Repository;
using Scrumler.Entity.Dto;
using Scrumler.Entity.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Scrumler.Bll
{
    public class KullaniciBL : BllBase<Kullanici, DtoKullanici>, IKullaniciBL
    {
        public readonly IKullaniciRepository _repository;
        public readonly IKullaniciYetkiRepository _permissionRepository;

        public KullaniciBL(IServiceProvider service) : base(service)
        {
            _repository = service.GetService<IKullaniciRepository>();
            _permissionRepository = service.GetService<IKullaniciYetkiRepository>();
        }

        public DtoSession Login(DtoLogin dtoLogin)
        {
            var result = new DtoSession();
            var user = _repository.CheckUser(dtoLogin);
            if (user != null)
            {
                result.KullaniciBilgileri = Mapper.Map<Kullanici, DtoKullanici>(user);
                var permissions = _permissionRepository.GetUserPermissios(user.KullaniciID);
                result.KullaniciYetkileri = permissions.Select(x => Mapper.Map<DtoKullaniciYetki>(x)).ToList();
            }

            return result;
        }
    }
}