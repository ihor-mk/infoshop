namespace InfoShop.Core.DAL.Entities
{
    public class Isp
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ContractNumber { get; set; } = string.Empty;
        public string ContractWith { get; set; } = string.Empty;
        public ICollection<IspContact> IspContacts { get; set; } = new List<IspContact>();
        public string Description { get; set; } = string.Empty;
    }
}
