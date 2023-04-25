using AutoMapper;
using InfoShop.Core.BLL.Interfaces;
using InfoShop.Core.BLL.Services.Abstract;
using InfoShop.Core.Common.DTO.Isp;
using InfoShop.Core.Common.DTO.Isp.IspContact;
using InfoShop.Core.DAL.Context;
using InfoShop.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

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

        public async Task<ICollection<IspDto>> GetAllIspAsync()
        {
            return _mapper.Map<ICollection<IspDto>>(await _context.Isps.ToListAsync())
                .GroupJoin(_context.IspContacts,
                    isp => isp.Id,
                    contact => contact.IspId,
                    (isp, cont) => new IspDto
                    {
                        Id = isp.Id,
                        ContractNumber = isp.ContractNumber,
                        ContractWith = isp.ContractWith,
                        Description = isp.Description,
                        IspContacts = _mapper.Map<ICollection<IspContactDto>>(cont),
                        Name = isp.Name
                    })
                .ToList();
        }

        public Task<IspDto> GetIspAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}
