using Scrumler.Bll.Abstract;
using Scrumler.Bll.Base;
using Scrumler.Dal.Abstract.Repository;
using Scrumler.Entity.Dto;
using Scrumler.Entity.Models;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Scrumler.Bll
{
    public class KullaniciYetkiBL : BllBase<KullaniciYetki, DtoKullaniciYetki>, IKullaniciYetkiBL
    {
        public readonly IKullaniciYetkiRepository _repository;

        public KullaniciYetkiBL(IServiceProvider service) : base(service)
        {
            _repository = service.GetService<IKullaniciYetkiRepository>();
        }
    }
}