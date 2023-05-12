using InfoShop.Core.Common.Enums;

namespace InfoShop.Core.Common.DTO.Isp.IspContact
{
    public class IspContactDto
    {
        public long Id { get; set; }
        public CommunicationType CommunicationType { get; set; }
        public string Value { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}