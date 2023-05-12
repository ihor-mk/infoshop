using InfoShop.Core.Common.Enums;

namespace InfoShop.Core.DAL.Entities
{
    public class Connection
    {
        public long Id { get; set; }
        public long? MarketId { get; set; }
        public Market Market { get; set; } = null!;
        public long? IspId { get; set; }
        public Isp Isp { get; set; } = null!;
        public ConnectionType Type { get; set; }
        public ICollection<ConnectionDetail> ConnectionDetails { get; set; } = new List<ConnectionDetail>();
        public string ContractNumber { get; set; } = string.Empty;
        public string ContractWith { get; set; } = string.Empty;
        public string Interface { get; set; } = string.Empty;
    }
}