using InfoShop.Core.Common.DTO.Connection;

namespace InfoShop.Core.BLL.Interfaces
{
    public interface IConnectionService
    {
        Task<ICollection<ConnectionDto>> GetConnectionsAsync(long marketId);
        Task<NewConnectionDto> CreateConnectionAsync(NewConnectionDto ispDto);
    }
}
