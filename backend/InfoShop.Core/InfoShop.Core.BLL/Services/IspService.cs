using AutoMapper;
using InfoShop.Core.BLL.Interfaces;
using InfoShop.Core.BLL.Services.Abstract;
using InfoShop.Core.Common.DTO.Isp;
using InfoShop.Core.DAL.Context;
using InfoShop.Core.DAL.Entities;

namespace InfoShop.Core.BLL.Services
{
    public class IspService : BaseService, IIspService
    {
        public IspService(InfoShopCoreContext context, IMapper mapper)
            : base(context, mapper) { }

        public async Task<NewIspDto> CreateIspAsync(NewIspDto ispDto)
        {
            var ispContacts = _mapper.Map<ICollection<IspContact>>(ispDto.IspContacts);

            var newIsp = _mapper.Map<Isp>(ispDto);

            newIsp.IspContacts = ispContacts;

            await _context.Isps.AddAsync(newIsp);

            await _context.SaveChangesAsync();

            return ispDto;
        }

        public Task<ICollection<IspDto>> GetAllIspAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IspDto> GetIspAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}
