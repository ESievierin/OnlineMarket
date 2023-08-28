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
            var data = await db.Orders.FindAsync(id);

            if(data != null)
                db.Orders.Remove(data);

            var orderGoods = db.OrderGoods.Where(og => og.OrderId == id);
                
            db.OrderGoods.RemoveRange(orderGoods);
        }

        public void Update(Order newOrder)
        {
            db.Entry(newOrder).State = EntityState.Modified;
            db.Orders.Update(newOrder);
        }
    }
}
