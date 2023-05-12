namespace InfoShop.Core.DAL.Entities
{
    public class Isp
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<IspContact> IspContacts { get; set; } = new List<IspContact>();
        public ICollection<Connection> Connections { get; set; } = new List<Connection>();
        public string? Description { get; set; } = string.Empty;
    }
}