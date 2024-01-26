using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OnlineMarket.DAL.Entities;

namespace OnlineMarket.DAL.EF
{
    public sealed class OnlineMarketContext : DbContext
    {

        public OnlineMarketContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderGoods>().HasKey(og => new { og.GoodId, og.OrderId });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile("appsettings.local.json")
            .Build();
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        }
        
        public DbSet<Customer> Customers { get; set; } = null!;

        public DbSet<Good> Goods { get; set; } = null!;

        public DbSet<Order> Orders { get; set; } = null!;

        public DbSet<OrderGoods> OrderGoods { get; set; } = null!;
    }
}
