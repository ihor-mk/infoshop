using InfoShop.Core.Common.Enums;

namespace InfoShop.Core.Common.DTO.Market
{
    public class NewMarketDto
    {
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public Region Region { get; set; }
        public string IntrenalNumber { get; set; } = string.Empty;
    }
}