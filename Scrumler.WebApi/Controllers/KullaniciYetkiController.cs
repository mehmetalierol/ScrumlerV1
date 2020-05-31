using Scrumler.Bll.Abstract;
using Scrumler.Entity.Dto;
using Scrumler.Entity.Models;
using Scrumler.WebApi.Base;
using Microsoft.AspNetCore.Mvc;

namespace Scrumler.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KullaniciYetkiController : ApiBase<IKullaniciYetkiBL, KullaniciYetki, DtoKullaniciYetki>
    {
        public KullaniciYetkiController(IKullaniciYetkiBL bl) : base(bl)
        {
        }
    }
}