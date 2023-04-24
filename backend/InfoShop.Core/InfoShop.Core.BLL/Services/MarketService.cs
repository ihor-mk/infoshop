using AutoMapper;
using InfoShop.Core.BLL.Interfaces;
using InfoShop.Core.BLL.Services.Abstract;
using InfoShop.Core.Common.DTO.Market;
using InfoShop.Core.DAL.Context;
using InfoShop.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace InfoShop.Core.BLL.Services
{
    public class MarketService : BaseService, IMarketService
    {
        public MarketService(InfoShopCoreContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<NewMarketDto> CreateMarketAsync(NewMarketDto marketDto)
        {
            var market = _mapper.Map<Market>(marketDto);

            await _context.Markets.AddAsync(market);
            await _context.SaveChangesAsync();

            return marketDto;
        }

        public async Task<ICollection<MarketDto>> GetAllMarketsAsync()
        {
            return await _context.Markets
                .Select(m => _mapper.Map<MarketDto>(m))
                .ToListAsync();
        }
    }
}
