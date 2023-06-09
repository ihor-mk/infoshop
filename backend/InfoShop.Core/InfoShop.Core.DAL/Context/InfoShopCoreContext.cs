﻿using InfoShop.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace InfoShop.Core.DAL.Context
{
    public class InfoShopCoreContext : DbContext
    {
        public DbSet<Market> Markets { get; set; }
        public DbSet<Connection> Connections { get; set; }
        public DbSet<ConnectionDetail> ConnectionDetail { get; set; }
        public DbSet<Isp> Isps { get; set; }
        public DbSet<IspContact> IspContacts { get; set; }
        public InfoShopCoreContext(DbContextOptions<InfoShopCoreContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

            //// Configure the relationship between Connection and Market
            //modelBuilder.Entity<Connection>()
            //    .HasOne(c => c.Market)
            //    .WithMany(m => m.Connections)
            //    .HasForeignKey(c => c.MarketId);

            //// Configure the relationship between Connection and Isp
            //modelBuilder.Entity<Connection>()
            //    .HasOne(c => c.Isp)
            //    .WithMany()
            //    .HasForeignKey(c => c.IspId);

            //// ... other configurations

            //base.OnModelCreating(modelBuilder);
        }
    }
}
