using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfoShop.Core.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Isps",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Isps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Markets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntrenalNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IspContacts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommunicationType = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IspId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IspContacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IspContacts_Isps_IspId",
                        column: x => x.IspId,
                        principalTable: "Isps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Connections",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarketId = table.Column<long>(type: "bigint", nullable: true),
                    IspId = table.Column<long>(type: "bigint", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    ContractNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractWith = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Interface = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Connections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Connections_Isps_IspId",
                        column: x => x.IspId,
                        principalTable: "Isps",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Connections_Markets_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Markets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ConnectionDetail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectionDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConnectionDetail_Connections_ConnectionId",
                        column: x => x.ConnectionId,
                        principalTable: "Connections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Isps",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1L, "", "Укртелеком" },
                    { 2L, "", "Crazy Network" },
                    { 3L, "", "Колумбус (БіттерНет)" },
                    { 4L, "", "ПРОСТІР" },
                    { 5L, "", "ДатаГруп" },
                    { 6L, "", "РадіоНетворк" },
                    { 7L, "", "Мальта" }
                });

            migrationBuilder.InsertData(
                table: "Markets",
                columns: new[] { "Id", "Address", "IntrenalNumber", "IsActive", "Name", "Phone" },
                values: new object[,]
                {
                    { 1L, "вул. Князів Коріатовичів, 13", "", true, "Кам'янець-Подільський 7", "+380675089930" },
                    { 2L, "вул. Князя Василька, 2", "", true, "Володимир-Волинський 3", "+380675069673" },
                    { 3L, "вул. Стефаника, 1", "", true, "Снятин 5", "+380671979140" },
                    { 4L, "вул. Героїв Небесної Сотні, 33/1", "", true, "Шепетівка 1", "+380675084559" },
                    { 5L, "вул. Галицького Лева, 3а", "", true, "Старий Самбір 1", "+380673429840" },
                    { 6L, "вул. Оржевської, 2", "", true, "Новоград-Волинський 2", "+380673405315" }
                });

            migrationBuilder.InsertData(
                table: "Connections",
                columns: new[] { "Id", "ContractNumber", "ContractWith", "Interface", "IspId", "MarketId", "Type" },
                values: new object[,]
                {
                    { 1L, "НП-1/13-03", "Модрина.К", "FastEthernet0/1", 2L, 1L, 2 },
                    { 2L, "190104", "Граб.К", "FastEthernet0/1", 3L, 2L, 1 },
                    { 3L, "", "НьюВітаГруп", "GigabitEthernet0/1", 4L, 3L, 3 },
                    { 4L, "258340", "Каштан.К", "FastEthernet0/1", 5L, 4L, 1 },
                    { 5L, "", "Вільха.К", "FastEthernet0/1", 6L, 5L, 3 },
                    { 6L, "", "Модрина.К", "FastEthernet0/1", 7L, 6L, 2 },
                    { 7L, "", "НьюВітаГруп", "FastEthernet0/0.99", 1L, 1L, 2 },
                    { 8L, "", "НьюВітаГруп", "FastEthernet0/0.99", 1L, 2L, 2 },
                    { 9L, "", "НьюВітаГруп", "FastEthernet0/0.99", 1L, 4L, 2 },
                    { 10L, "", "НьюВітаГруп", "FastEthernet0/0.99", 1L, 5L, 2 },
                    { 11L, "", "НьюВітаГруп", "FastEthernet0/0.99", 1L, 6L, 2 }
                });

            migrationBuilder.InsertData(
                table: "IspContacts",
                columns: new[] { "Id", "CommunicationType", "Description", "IspId", "Value" },
                values: new object[,]
                {
                    { 1L, 2, "Адреса для створення заявок", 1L, "zmina@ukrtelecom.net" },
                    { 2L, 1, "Технічна підтримка", 2L, "0986781426" },
                    { 3L, 1, "Гаряча лінія", 3L, "0800317407" },
                    { 4L, 1, "Офіс", 4L, "0979244224" },
                    { 5L, 1, "Офіс", 5L, "0800 211 000" },
                    { 6L, 1, "Технічна підтримка", 7L, "0674800808" },
                    { 7L, 1, "Оксана", 7L, "0673701747" }
                });

            migrationBuilder.InsertData(
                table: "ConnectionDetail",
                columns: new[] { "Id", "ConnectionId", "Key", "Value" },
                values: new object[,]
                {
                    { 1L, 1L, "IP-address", "95.47.248.199" },
                    { 2L, 1L, "Mask", "255.255.255.128" },
                    { 3L, 1L, "Gateway", "255.255.255.129" },
                    { 4L, 2L, "IP-address", "46.173.121.91" },
                    { 5L, 2L, "MAC-binding", "false" },
                    { 6L, 3L, "IP-address", "93.170.188.251" },
                    { 7L, 3L, "PPPoE-Login", "30246899" },
                    { 8L, 3L, "PPPoE-Password", "82169755" },
                    { 9L, 4L, "IP-address", "80.77.33.161" },
                    { 10L, 4L, "MAC-binding", "true" },
                    { 11L, 5L, "IP-address", "176.118.54.50" },
                    { 12L, 5L, "PPPoE-Login", "000020390" },
                    { 13L, 5L, "PPPoE-Password", "02092020" },
                    { 14L, 6L, "IP-address", "195.46.32.87" },
                    { 15L, 6L, "Mask", "255.255.255.0" },
                    { 16L, 6L, "Gateway", "195.46.32.2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConnectionDetail_ConnectionId",
                table: "ConnectionDetail",
                column: "ConnectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Connections_IspId",
                table: "Connections",
                column: "IspId");

            migrationBuilder.CreateIndex(
                name: "IX_Connections_MarketId",
                table: "Connections",
                column: "MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_IspContacts_IspId",
                table: "IspContacts",
                column: "IspId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConnectionDetail");

            migrationBuilder.DropTable(
                name: "IspContacts");

            migrationBuilder.DropTable(
                name: "Connections");

            migrationBuilder.DropTable(
                name: "Isps");

            migrationBuilder.DropTable(
                name: "Markets");
        }
    }
}
