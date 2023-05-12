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
        cfg.AddProfile<ConnectionProfile>();
    });

builder.Services.AddTransient<IMarketService, MarketService>();
builder.Services.AddTransient<IIspService, IspService>();
builder.Services.AddTransient<IConnectionService, ConnectionService>();

builder.Services.AddDbContext<InfoShopCoreContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("InfoShopCoreDBConnection")));

builder.Services.AddCors();

var app = builder.Build();

app.UseCors(opt => opt
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowAnyOrigin());

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
