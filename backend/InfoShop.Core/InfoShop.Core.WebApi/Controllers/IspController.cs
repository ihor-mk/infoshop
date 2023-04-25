using InfoShop.Core.BLL.Interfaces;
using InfoShop.Core.Common.DTO.Isp;
using Microsoft.AspNetCore.Mvc;

namespace InfoShop.Core.WebApi.Controllers
{
    [ApiController]
    [Route("isp")]
    public class IspController : ControllerBase
    {
        private readonly IIspService _ispService;

        public IspController (IIspService ispService)
        {
            _ispService = ispService;
        }

        [HttpPut]
        public async Task<ActionResult<NewIspDto>> CreateIsp(NewIspDto newIsp)
        {
            var isp = await _ispService.CreateIspAsync(newIsp);
            return Ok(isp);
        }
    }
}
