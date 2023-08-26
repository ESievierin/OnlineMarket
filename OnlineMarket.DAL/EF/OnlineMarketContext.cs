using Microsoft.EntityFrameworkCore;
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
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=OnlineMarketDB;Username=postgres;Password=VRTS17axD");
        }
        
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Good> Goods { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderGoods> OrderGoods { get; set; }
    }
}
