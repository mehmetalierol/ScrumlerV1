using AutoMapper;
using Scrumler.Entity.Dto;
using Scrumler.Entity.Models;
using Scrumler.Entity.ViewModels.Responses.Malzeme;

namespace Scrumler.Entity.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Kullanici, DtoKullanici>().ReverseMap();
            CreateMap<KullaniciYetki, DtoKullaniciYetki>().ReverseMap();
            CreateMap<Yetki, DtoYetki>().ReverseMap();

            //Bu şekilde yazılırsa sadece istenen alan geliyor. ##SONKISIM
            //CreateMap<Isyeri, ResponseIsyeriJustName>().ReverseMap();

            //CreateMap<ApplicationUser, ApplicationUserDto>().ReverseMap()
            // .ForMember(a => a.PasswordHash, b => b.MapFrom(c => c.Password));

            //Hedef ve kaynak arasında property isimleri farklı ise aşağıdaki gibi eşleştirme yapılır
            //.ForMember(a => a.Name, b => b.MapFrom(c => c.ModelName))

            //Bir propertynin görmezden gelinmesi isteniyor ise aşağıdaki gibi bir tanımlama yapılmalıdır.
            //.ForSourceMember(x => x.Name, opt => opt.Ignore());
        }
    }
}