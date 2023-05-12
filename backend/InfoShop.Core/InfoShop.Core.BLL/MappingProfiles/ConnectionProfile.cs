using AutoMapper;
using InfoShop.Core.Common.DTO.Connection;
using InfoShop.Core.Common.DTO.Connection.ConnectionDetail;
using InfoShop.Core.DAL.Entities;

namespace InfoShop.Core.BLL.MappingProfiles
{
    public class ConnectionProfile : Profile
    {
        public ConnectionProfile() 
        {
            CreateMap<Connection, ConnectionDto>().ReverseMap();
            CreateMap<Connection, NewConnectionDto>().ReverseMap();

            CreateMap<ConnectionDetail, ConnectionDetailDto>().ReverseMap();
            CreateMap<ConnectionDetail, NewConnectionDetailDto>().ReverseMap();
        }
    }
}
