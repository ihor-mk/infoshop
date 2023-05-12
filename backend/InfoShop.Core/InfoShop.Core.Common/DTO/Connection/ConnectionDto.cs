using InfoShop.Core.Common.DTO.Connection.ConnectionDetail;
using InfoShop.Core.Common.Enums;

namespace InfoShop.Core.Common.DTO.Connection
{
    public class ConnectionDto
    {
        public long Id { get; set; }
        public long MarketId { get; set; }
        public long IspId { get; set; }
        public ConnectionType Type { get; set; }
        public List<ConnectionDetailDto> ConnectionDetails { get; set; } = new List<ConnectionDetailDto>();
        public string ContractNumber { get; set; } = string.Empty;
        public string ContractWith { get; set; } = string.Empty;
        public string Interface { get; set; } = string.Empty;
    }
}
