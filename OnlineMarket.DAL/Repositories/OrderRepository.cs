using OnlineMarket.DAL.EF;
using OnlineMarket.DAL.Entities;
using OnlineMarket.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace OnlineMarket.DAL.Repositories
{
    public sealed class OrderRepository : IOrderRepository
    {
        private readonly OnlineMarketContext db;

        public OrderRepository(OnlineMarketContext db)
        {
            this.db = db;
        }

        public async Task<Order> GetAsync(int id) =>
           await db.Orders.FindAsync(id);

        public async Task CreateAsync(Order order, int[] goodsids)
        {
            var createdOrder = db.Orders.Add(order);
            await db.SaveChangesAsync();

            var orderGoods = goodsids.Select(g => new OrderGoods { GoodId = g, OrderId = createdOrder.Entity.Id});
            db.OrderGoods.AddRange(orderGoods);            
        }

        public async Task DeleteAsync(int id)
        {
            var order = await db.Orders.FindAsync(id);

            if(order != null)
            {
                db.Orders.Remove(order);

                var orderGoods = db.OrderGoods.Where(og => og.OrderId == id);
                db.OrderGoods.RemoveRange(orderGoods);
            }      
        }

        public void Update(Order newOrder) =>
            db.Orders.Update(newOrder);     
    }
}
