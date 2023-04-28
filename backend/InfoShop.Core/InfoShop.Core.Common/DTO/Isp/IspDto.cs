using InfoShop.Core.Common.DTO.Isp.IspContact;

namespace InfoShop.Core.Common.DTO.Isp
{
    public  class IspDto
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ContractNumber { get; set; } = string.Empty;
        public string ContractWith { get; set; } = string.Empty;
        public List<IspContactDto> IspContacts { get; set; } = new List<IspContactDto>();
        public string Description { get; set; } = string.Empty;
    }
}