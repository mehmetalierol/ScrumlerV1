using Scrumler.Bll.Abstract;
using Scrumler.Entity.Dto;
using Scrumler.Entity.Models;
using Scrumler.WebApi.Base;
using Microsoft.AspNetCore.Mvc;

namespace Scrumler.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class YetkiController : ApiBase<IYetkiBL, Yetki, DtoYetki>
    {
        public YetkiController(IYetkiBL bl) : base(bl)
        {
        }
    }
}