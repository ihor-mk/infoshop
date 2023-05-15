using InfoShop.Core.Common.Enums;

namespace InfoShop.Core.Common.DTO.Market
{
    public class MarketDto
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string IntrenalNumber { get; set; } = string.Empty;
        public Region Region { get; set; }
        public bool IsActive { get; set; } = true;
    }
}