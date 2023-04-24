using AutoMapper;
using InfoShop.Core.Common.DTO.Market;
using InfoShop.Core.DAL.Entities;

namespace InfoShop.Core.BLL.MappingProfiles
{
    public class MarketProfile : Profile
    {
        public MarketProfile() 
        {
            CreateMap<NewMarketDto, Market>().ReverseMap();
            CreateMap<MarketDto, Market>().ReverseMap();
        }
    }
}
