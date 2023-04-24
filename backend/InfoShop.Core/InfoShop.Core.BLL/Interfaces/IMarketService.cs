﻿using InfoShop.Core.Common.DTO.Market;
using InfoShop.Core.DAL.Entities;

namespace InfoShop.Core.BLL.Interfaces
{
    public interface IMarketService
    {
        Task<ICollection<MarketDto>> GetAllMarketsAsync();
        Task<NewMarketDto> CreateMarketAsync(NewMarketDto marketDto);
    }
}
