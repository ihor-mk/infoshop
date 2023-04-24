using InfoShop.Core.BLL.Interfaces;
using InfoShop.Core.Common.DTO.Market;
using Microsoft.AspNetCore.Mvc;

namespace InfoShop.Core.WebApi.Controllers
{

    [ApiController]
    [Route("markets")]
    public class MarketController : ControllerBase
    {
        private readonly IMarketService _marketService;

        public MarketController(IMarketService marketService)
        {
            _marketService = marketService;
        }
        [HttpGet]
        public async Task<ActionResult<ICollection<MarketDto>>> GetAllMarkets()
        {
            var markets = await _marketService.GetAllMarketsAsync();
            return Ok(markets);
        }

        [HttpPut]
        public async Task<IActionResult> CreateMarket(NewMarketDto newMarket)
        {
            var market = await _marketService.CreateMarketAsync(newMarket);
            return Ok(market);
        }
    }
}
