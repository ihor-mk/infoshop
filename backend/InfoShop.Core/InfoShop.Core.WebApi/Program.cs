using Microsoft.EntityFrameworkCore;
using InfoShop.Core.DAL.Context;
using InfoShop.Core.BLL.Interfaces;
using InfoShop.Core.BLL.Services;
using InfoShop.Core.BLL.MappingProfiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(cfg =>
    {
        cfg.AddProfile<MarketProfile>();
        cfg.AddProfile<IspProfile>();
    });

builder.Services.AddTransient<IMarketService, MarketService>();

builder.Services.AddDbContext<InfoShopCoreContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("InfoShopCoreDBConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
