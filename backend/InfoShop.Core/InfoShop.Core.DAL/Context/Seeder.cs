using InfoShop.Core.Common.Enums;
using InfoShop.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace InfoShop.Core.DAL.Context
{
    public static class Seeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var markets = CreateMarkets();
            var isps = CreateIsps();
            var ispContacts = CreateIspContacts();
            var connections = CreateConnections();
            var connectionDetails = CreateConnectionDetails();

            modelBuilder.Entity<Market>().HasData(markets);
            modelBuilder.Entity<Isp>().HasData(isps);
            modelBuilder.Entity<IspContact>().HasData(ispContacts);
            modelBuilder.Entity<Connection>().HasData(connections);
            modelBuilder.Entity<ConnectionDetail>().HasData(connectionDetails);
        }

        public static IList<Market> CreateMarkets()
        {
            return new List<Market>
            {
                new Market
                {
                    Id = 1,
                    Name = "Кам'янець-Подільський 7",
                    Address = "вул. Князів Коріатовичів, 13",
                    IsActive = true,
                    Phone = "+380675089930"
                },

                new Market
                {
                    Id = 2,
                    Name = "Володимир-Волинський 3",
                    Address = "вул. Князя Василька, 2",
                    IsActive = true,
                    Phone = "+380675069673"
                },

                new Market
                {
                    Id = 3,
                    Name = "Снятин 5",
                    Address = "вул. Стефаника, 1",
                    IsActive = true,
                    Phone = "+380671979140"
                },

                new Market
                {
                    Id = 4,
                    Name = "Шепетівка 1",
                    Address = "вул. Героїв Небесної Сотні, 33/1",
                    IsActive = true,
                    Phone = "+380675084559"
                },

                new Market
                {
                    Id = 5,
                    Name = "Старий Самбір 1",
                    Address = "вул. Галицького Лева, 3а",
                    IsActive = true,
                    Phone = "+380673429840"
                },

                new Market
                {
                    Id = 6,
                    Name = "Новоград-Волинський 2",
                    Address = "вул. Оржевської, 2",
                    IsActive = true,
                    Phone = "+380673405315"
                }
            };
        }

        public static IList<Isp> CreateIsps()
        {
            return new List<Isp>
            {
                new Isp
                {
                    Id = 1,
                    Name = "Укртелеком",
                },

                new Isp
                {
                    Id = 2,
                    Name = "Crazy Network",
                },

                new Isp
                {
                    Id = 3,
                    Name = "Колумбус (БіттерНет)",
                },


                new Isp
                {
                    Id = 4,
                    Name = "ПРОСТІР",
                },

                new Isp
                {
                    Id = 5,
                    Name = "ДатаГруп",
                },

                new Isp
                {
                    Id = 6,
                    Name = "РадіоНетворк",
                },

                new Isp
                {
                    Id = 7,
                    Name = "Мальта",
                },

            };
        }

        public static IList<IspContact> CreateIspContacts()
        {
            return new List<IspContact>
            {
                new IspContact
                {
                    Id = 1,
                    CommunicationType = CommunicationType.Email,
                    IspId = 1,
                    Value = "zmina@ukrtelecom.net",
                    Description = "Адреса для створення заявок"
                },

                new IspContact
                {
                    Id = 2,
                    CommunicationType = CommunicationType.Phone,
                    IspId = 2,
                    Value = "0986781426",
                    Description = "Технічна підтримка"
                },

                 new IspContact
                 {
                    Id = 3,
                    CommunicationType = CommunicationType.Phone,
                    IspId = 3,
                    Value = "0800317407",
                    Description = "Гаряча лінія"
                 },

                 new IspContact
                 {
                    Id = 4,
                    CommunicationType = CommunicationType.Phone,
                    IspId = 4,
                    Value = "0979244224",
                    Description = "Офіс"
                 },

                 new IspContact
                 {
                    Id = 5,
                    CommunicationType = CommunicationType.Phone,
                    IspId = 5,
                    Value = "0800 211 000",
                    Description = "Офіс"
                 },

                 new IspContact
                 {
                    Id = 6,
                    CommunicationType = CommunicationType.Phone,
                    IspId = 7,
                    Value = "0674800808",
                    Description = "Технічна підтримка"
                 },

                 new IspContact
                 {
                    Id = 7,
                    CommunicationType = CommunicationType.Phone,
                    IspId = 7,
                    Value = "0673701747",
                    Description = "Оксана"
                 }
            };
        }

        public static IList<Connection> CreateConnections()
        {
            return new List<Connection>
            {
                new Connection
                {
                    Id = 1,
                    MarketId = 1,
                    IspId = 2,
                    ContractNumber = "НП-1/13-03",
                    Type = ConnectionType.Static,
                    ContractWith = "Модрина.К",
                    Interface = "FastEthernet0/1",
                },

                new Connection
                {
                    Id = 2,
                    MarketId = 2,
                    IspId = 3,
                    ContractNumber = "190104",
                    Type = ConnectionType.DHCP,
                    ContractWith = "Граб.К",
                    Interface = "FastEthernet0/1",
                },

                new Connection
                {
                    Id = 3,
                    MarketId = 3,
                    IspId = 4,
                    ContractNumber = "",
                    Type = ConnectionType.PPPoE,
                    ContractWith = "НьюВітаГруп",
                    Interface = "GigabitEthernet0/1",
                },

                new Connection
                {
                    Id = 4,
                    MarketId = 4,
                    IspId = 5,
                    ContractNumber = "258340",
                    Type = ConnectionType.DHCP,
                    ContractWith = "Каштан.К",
                    Interface = "FastEthernet0/1",
                },

                new Connection
                {
                    Id = 5,
                    MarketId = 5,
                    IspId = 6,
                    ContractNumber = "",
                    Type = ConnectionType.PPPoE,
                    ContractWith = "Вільха.К",
                    Interface = "FastEthernet0/1",
                },

                new Connection
                {
                    Id = 6,
                    MarketId = 6,
                    IspId = 7,
                    ContractNumber = "",
                    Type = ConnectionType.Static,
                    ContractWith = "Модрина.К",
                    Interface = "FastEthernet0/1",
                },

                new Connection
                {
                    Id = 7,
                    MarketId = 1,
                    IspId = 1,
                    ContractNumber = "",
                    Type = ConnectionType.Static,
                    ContractWith = "НьюВітаГруп",
                    Interface = "FastEthernet0/0.99",
                },

                new Connection
                {
                    Id = 8,
                    MarketId = 2,
                    IspId = 1,
                    ContractNumber = "",
                    Type = ConnectionType.Static,
                    ContractWith = "НьюВітаГруп",
                    Interface = "FastEthernet0/0.99",
                },

                new Connection
                {
                    Id = 9,
                    MarketId = 4,
                    IspId = 1,
                    ContractNumber = "",
                    Type = ConnectionType.Static,
                    ContractWith = "НьюВітаГруп",
                    Interface = "FastEthernet0/0.99",
                },

                new Connection
                {
                    Id = 10,
                    MarketId = 5,
                    IspId = 1,
                    ContractNumber = "",
                    Type = ConnectionType.Static,
                    ContractWith = "НьюВітаГруп",
                    Interface = "FastEthernet0/0.99",
                },

                new Connection
                {
                    Id = 11,
                    MarketId = 6,
                    IspId = 1,
                    ContractNumber = "",
                    Type = ConnectionType.Static,
                    ContractWith = "НьюВітаГруп",
                    Interface = "FastEthernet0/0.99",
                }
            };
        }

        public static IList<ConnectionDetail> CreateConnectionDetails()
        {
            return new List<ConnectionDetail>
            {
                new ConnectionDetail 
                {
                    Id = 1,
                    ConnectionId = 1,
                    Key = "IP-address",
                    Value = "95.47.248.199",
                },

                new ConnectionDetail
                {
                    Id = 2,
                    ConnectionId = 1,
                    Key = "Mask",
                    Value = "255.255.255.128",
                },

                new ConnectionDetail
                {
                    Id = 3,
                    ConnectionId = 1,
                    Key = "Gateway",
                    Value = "255.255.255.129",
                },

                new ConnectionDetail
                {
                    Id = 4,
                    ConnectionId = 2,
                    Key = "IP-address",
                    Value = "46.173.121.91",
                },

                new ConnectionDetail
                {
                    Id = 5,
                    ConnectionId = 2,
                    Key = "MAC-binding",
                    Value = "false",
                },

                new ConnectionDetail
                {
                    Id = 6,
                    ConnectionId = 3,
                    Key = "IP-address",
                    Value = "93.170.188.251",
                },

                new ConnectionDetail
                {
                    Id = 7,
                    ConnectionId = 3,
                    Key = "PPPoE-Login",
                    Value = "30246899",
                },

                new ConnectionDetail
                {
                    Id = 8,
                    ConnectionId = 3,
                    Key = "PPPoE-Password",
                    Value = "82169755",
                },

                new ConnectionDetail
                {
                    Id = 9,
                    ConnectionId = 4,
                    Key = "IP-address",
                    Value = "80.77.33.161",
                },

                new ConnectionDetail
                {
                    Id = 10,
                    ConnectionId = 4,
                    Key = "MAC-binding",
                    Value = "true",
                },

                new ConnectionDetail
                {
                    Id = 11,
                    ConnectionId = 5,
                    Key = "IP-address",
                    Value = "176.118.54.50",
                },

                new ConnectionDetail
                {
                    Id = 12,
                    ConnectionId = 5,
                    Key = "PPPoE-Login",
                    Value = "000020390",
                },

                new ConnectionDetail
                {
                    Id = 13,
                    ConnectionId = 5,
                    Key = "PPPoE-Password",
                    Value = "02092020",
                },

                new ConnectionDetail
                {
                    Id = 14,
                    ConnectionId = 6,
                    Key = "IP-address",
                    Value = "195.46.32.87",
                },

                new ConnectionDetail
                {
                    Id = 15,
                    ConnectionId = 6,
                    Key = "Mask",
                    Value = "255.255.255.0",
                },

                new ConnectionDetail
                {
                    Id = 16,
                    ConnectionId = 6,
                    Key = "Gateway",
                    Value = "195.46.32.2",
                }
            };
        }
    }
}
