namespace InfoShop.Core.DAL.Entities
{
    public class ConnectionDetail
    {
        public long Id { get; set; }
        public string Key { get; set; } = string.Empty;

        public string Value { get; set; } = string.Empty;

        public long ConnectionId { get; set; } 
        public Connection Connection { get; set; } = new Connection();
    }
}
