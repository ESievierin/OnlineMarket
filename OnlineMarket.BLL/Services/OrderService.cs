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
        private readonly IWorkForUnit database;

        public OrderService(IWorkForUnit database)
        {
            this.database = database;
        }

        public async Task<OrderDTO> GetAsync(int id) =>
            mapper.Map<OrderDTO>(await database.Orders.GetAsync(id));

        public async Task CreateAsync(OrderDTO order, GoodDTO[] goods)
        {
            database.Orders.Create(mapper.Map<Order>(order), mapper.Map<Good[]>(goods));
            await database.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await database.Orders.DeleteAsync(id);
            await database.SaveAsync();
        }

        public async Task UpdateAsync(OrderDTO newOrder)
        {
            database.Orders.Update(mapper.Map<Order>(newOrder));
            await database.SaveAsync();
        }   
    }
}
