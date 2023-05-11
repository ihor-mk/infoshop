using AutoMapper;
using InfoShop.Core.BLL.Services.Abstract;
using InfoShop.Core.Common.DTO.Isp.IspContact;
using InfoShop.Core.Common.DTO.Isp;
using InfoShop.Core.DAL.Context;
using InfoShop.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using InfoShop.Core.BLL.Interfaces;
using InfoShop.Core.Common.DTO.Connection;
using InfoShop.Core.Common.DTO.Connection.ConnectionDetail;

namespace InfoShop.Core.BLL.Services
{
    public class ConnectionService : BaseService, IConnectionService
    {
        public ConnectionService (InfoShopCoreContext context, IMapper mapper)
            : base(context, mapper) { }


        public async Task<NewConnectionDto> CreateConnectionAsync(NewConnectionDto connectionDto)
        {
            var connectionDetails = _mapper.Map<ICollection<ConnectionDetail>>(connectionDto.ConnectionDetails);

            var newConnection = _mapper.Map<Connection>(connectionDto);

            newConnection.ConnectionDetails = connectionDetails;

            await _context.Connections.AddAsync(newConnection);

            await _context.SaveChangesAsync();

            return connectionDto;
        }


        public async Task<ICollection<ConnectionDto>> GetConnectionsAsync(long marketId)
        {
            var connections = _mapper.Map<List<ConnectionDto>>(await _context.Connections
                .Where(c => c.MarketId == marketId)
                .ToListAsync());

            if (connections is not null)
            {
                return connections
                    .GroupJoin(_context.ConnectionDetail,
                        conn => conn.Id,
                        det => det.ConnectionId,
                        (conn, det) => new ConnectionDto
                        {
                            Id = conn.Id,
                            IspId = conn.IspId,
                            MarketId = conn.MarketId,
                            Type = conn.Type,
                            ConnectionPort = conn.ConnectionPort,
                            ConnectionDetails = _mapper.Map<List<ConnectionDetailDto>>(det)
                        })
                    .ToList();
            }

            return connections!;
        }

    }
}
