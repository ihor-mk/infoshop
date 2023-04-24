using InfoShop.Core.DAL.Entities.Enums;

namespace InfoShop.Core.DAL.Entities
{
    public class Connection
    {
        public long Id { get; set; }
        public long MarketId { get; set; }
        public Market Market { get; set; } = new Market();
        public long IspId { get; set; }
        public Isp Isp { get; set; } = new Isp();
        public ConnectionType Type { get; set; }
        public ICollection<ConnectionDetail> ConnectionDetails { get; set; } = new List<ConnectionDetail>();
        public string ConnectionPort { get; set; } = string.Empty;
    }
}
