using InfoShop.Core.Common.Enums;

namespace InfoShop.Core.DAL.Entities
{
    public class IspContact
    {
        public long Id { get; set; }
        public CommunicationType CommunicationType { get; set; }
        public string Value { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public long IspId { get; set; }
        public Isp Isp { get; set; } = null!;
    }
}
