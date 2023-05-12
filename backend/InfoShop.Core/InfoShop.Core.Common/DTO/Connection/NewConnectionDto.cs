using InfoShop.Core.Common.DTO.Connection.ConnectionDetail;
using InfoShop.Core.Common.Enums;

namespace InfoShop.Core.Common.DTO.Connection
{
    public class NewConnectionDto
    {
        public long MarketId { get; set; }
        public long IspId { get; set; }
        public ConnectionType Type { get; set; }
        public List<NewConnectionDetailDto> ConnectionDetails { get; set; } = new List<NewConnectionDetailDto>();
        public string ContractNumber { get; set; } = string.Empty;
        public string ContractWith { get; set; } = string.Empty;
        public string Interface { get; set; } = string.Empty;
    }
}
