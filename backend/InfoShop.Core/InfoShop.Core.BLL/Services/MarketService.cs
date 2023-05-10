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

            Console.WriteLine(market.Id);

            return marketDto;
        }

        public async Task<ICollection<MarketDto>> GetAllMarketsAsync()
        {
            return await _context.Markets
                .OrderBy(m => m.Name)
                .Select(m => _mapper.Map<MarketDto>(m))
                .ToListAsync();
        }

        public async Task<MarketDto> GetMarketAsync(long id)
        {
            var market = await _context.Markets
                .FirstOrDefaultAsync(m => m.Id == id);

            var marketDto = _mapper.Map<MarketDto>(market);

            return marketDto;
        }
    }
}
