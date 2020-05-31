using Scrumler.Bll.Abstract;
using Scrumler.Bll.Base;
using Scrumler.Dal.Abstract.Repository;
using Scrumler.Entity.Dto;
using Scrumler.Entity.Models;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Scrumler.Bll
{
    public class YetkiBL : BllBase<Yetki, DtoYetki>, IYetkiBL
    {
        public readonly IYetkiRepository _repository;

        public YetkiBL(IServiceProvider service) : base(service)
        {
            _repository = service.GetService<IYetkiRepository>();
        }
    }
}