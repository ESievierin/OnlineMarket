using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql.EntityFrameworkCore.PostgreSQL;
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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=OnlineMarketDB;Username=postgres;Password=VRTS17axD");
        }
        
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Goods> Goods { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderGoods> OrderGoods { get; set; }
    }
}
