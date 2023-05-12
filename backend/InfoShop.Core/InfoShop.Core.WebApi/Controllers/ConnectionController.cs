using InfoShop.Core.BLL.Interfaces;
using InfoShop.Core.BLL.Services;
using InfoShop.Core.Common.DTO.Connection;
using InfoShop.Core.Common.DTO.Isp;
using Microsoft.AspNetCore.Mvc;

namespace InfoShop.Core.WebApi.Controllers
{
    [ApiController]
    [Route("connections")]
    public class ConnectionController : ControllerBase
    {
        private readonly IConnectionService _connectionService;

        public ConnectionController(IConnectionService connectionService)
        {
            _connectionService = connectionService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<ConnectionDto>>> GetConnections(long id)
        {
            var connections = await _connectionService.GetConnectionsAsync(id);
            return Ok(connections);
        }

        [HttpPut]
        public async Task<ActionResult<NewConnectionDto>> CreateConnection(NewConnectionDto newConnection)
        {
            var connection = await _connectionService.CreateConnectionAsync(newConnection);

            return Ok(connection);
        }
    }
}
