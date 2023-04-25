using InfoShop.Core.Common.DTO.Market;

namespace InfoShop.Core.BLL.Interfaces
{
    public interface IIspService
    {
        Task<ICollection<MarketDto>> GetAllMarketsAsync();
        Task<MarketDto> GetMarketAsync(long id);
        Task<NewMarketDto> CreateMarketAsync(NewMarketDto marketDto);
    }
}