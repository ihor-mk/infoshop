using AutoMapper;
using InfoShop.Core.Common.DTO.Isp;
using InfoShop.Core.Common.DTO.Isp.IspContact;
using InfoShop.Core.DAL.Entities;

namespace InfoShop.Core.BLL.MappingProfiles
{
    public class IspProfile : Profile
    {
        public IspProfile() 
        {
            CreateMap<IspDto, Isp>().ReverseMap();
            CreateMap<NewIspDto, Isp>().ReverseMap();

            CreateMap<IspContactDto, IspContact>().ReverseMap();
            CreateMap<NewIspContactDto, IspContact>().ReverseMap();
        }
    }
}
