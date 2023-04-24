using InfoShop.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace InfoShop.Core.DAL.Context
{
    public class InfoShopCoreContext : DbContext
    {
        public InfoShopCoreContext(DbContextOptions<InfoShopCoreContext> options) : base(options) { }

        public DbSet<Market> Markets { get; set; }
        public DbSet<Connection> Connections { get; set; }

        public DbSet<ConnectionDetail> ConnectionDetail { get; set; }
        public DbSet<Isp> Isps { get; set; }
        public DbSet<IspContact> IspContacts { get; set; }

    }
}
