using InfoShop.Core.Common.DTO.Isp.IspContact;

namespace InfoShop.Core.Common.DTO.Isp
{
    public class NewIspDto
    {
        public string Name { get; set; } = string.Empty;
        public string ContractNumber { get; set; } = string.Empty;
        public string ContractWith { get; set; } = string.Empty;
        public ICollection<NewIspContactDto> IspContacts { get; set; } = new List<NewIspContactDto>();
        public string Description { get; set; } = string.Empty;
    }
}