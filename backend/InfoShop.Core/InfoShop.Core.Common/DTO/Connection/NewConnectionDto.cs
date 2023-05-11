using InfoShop.Core.Common.DTO.Connection.ConnectionDetail;
using InfoShop.Core.Common.Enums;

namespace InfoShop.Core.Common.DTO.Connection
{
    public class NewConnectionDto
    {
        public long MarketId { get; set; }
        public long IspId { get; set; }
        public ConnectionType Type { get; set; }
        public List<ConnectionDetailDto> ConnectionDetails { get; set; } = new List<ConnectionDetailDto>();
        public string ConnectionPort { get; set; } = string.Empty;
    }
}
