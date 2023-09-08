using AutoMapper;
using OnlineMarket.BLL.DTO;
using OnlineMarket.BLL.Interfaces;
using OnlineMarket.DAL.Entities;
using OnlineMarket.DAL.Interfaces;

namespace OnlineMarket.BLL.Services
{
    public sealed class OrderService : IOrderService
    {
        private IMapper mapper;
        private readonly IWorkForUnit Database;

        public OrderService(IWorkForUnit database)
        {
            Database = database;
        }

        public async Task<OrderDTO> GetAsync(int id) =>
            mapper.Map<OrderDTO>(await Database.Orders.GetAsync(id));

        public async Task CreateAsync(OrderDTO order, GoodDTO[] goods)
        {
            Database.Orders.Create(mapper.Map<Order>(order), mapper.Map<Good[]>(goods));
            await Database.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await Database.Orders.DeleteAsync(id);
            await Database.SaveAsync();
        }

        public async Task UpdateAsync(OrderDTO newOrder)
        {
            var order = await Database.Orders.GetAsync(newOrder.Id);

            if(order != null)
            {
                Database.Orders.Update(mapper.Map<Order>(newOrder));
                await Database.SaveAsync();
            }
        }   
    }
}
