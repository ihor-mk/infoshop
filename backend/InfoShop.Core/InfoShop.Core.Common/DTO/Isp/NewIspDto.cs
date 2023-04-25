namespace InfoShop.Core.Common.DTO.Isp
{
    public class NewIspDto
    {
        public string Name { get; set; } = string.Empty;
        public string ContractNumber { get; set; } = string.Empty;
        public string ContractWith { get; set; } = string.Empty;
        public ICollection<IspContactDto> IspContacts { get; set; } = new List<IspContactDto>();
        public string Description { get; set; } = string.Empty;
    }
}