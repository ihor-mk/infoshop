namespace InfoShop.Core.DAL.Entities
{
    public class Market
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string IntrenalNumber { get; set; } = string.Empty;
        public ICollection<Connection> Connections { get; set; } = new List<Connection>();
        public bool IsActive { get; set; } = true;
    }
}