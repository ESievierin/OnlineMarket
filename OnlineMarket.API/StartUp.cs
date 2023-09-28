using AutoMapper;
using OnlineMarket.API.Mapper;
using OnlineMarket.BLL.Interfaces;
using OnlineMarket.BLL.Services;
using OnlineMarket.DAL.Interfaces;
using OnlineMarket.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddTransient<IWorkForUnit, EFWorkForUnit>()
    .AddTransient<ICustomerService, CustomerService>()
    .AddTransient<IGoodService, GoodService>()
    .AddTransient<IOrderService, OrderService>();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile<OnlineMarketMapper>();
});

builder.Services.AddAutoMapper(typeof(OnlineMarketMapper));

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();



if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseCors("corsapp"); 

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
