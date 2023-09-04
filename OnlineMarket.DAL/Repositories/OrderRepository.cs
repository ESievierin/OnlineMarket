using OnlineMarket.DAL.EF;
using OnlineMarket.DAL.Entities;
using OnlineMarket.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace OnlineMarket.DAL.Repositories
{
    public sealed class OrderRepository : IOrderRepository
    {
        private readonly OnlineMarketContext db;

        public OrderRepository(OnlineMarketContext db)
        {
            this.db = db;
        }

        public async Task<Order> Get(int id) =>
           await db.Orders.FindAsync(id);

        public void Create(Order order, Good[] goods)
        {
            db.Orders.Add(order);

            var orderGoods = goods.Select(g => new OrderGoods { GoodId = g.Id, OrderId = order.Id });
            db.OrderGoods.AddRange(orderGoods);            
        }

        public async Task Delete(int id)
        {
            var good = await db.Goods.FindAsync(id);
            db.Goods.Remove(good);

            var orderGoods = db.OrderGoods.Where(og => og.OrderId == id);
        }

        public void Update(Order newOrder) =>
            db.Orders.Update(newOrder);     
    }
}
