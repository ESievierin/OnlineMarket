using AutoMapper;
using OnlineMarket.BLL.DTO;
using OnlineMarket.BLL.Interfaces;
using OnlineMarket.DAL.Entities;
using OnlineMarket.DAL.Interfaces;

namespace OnlineMarket.BLL.Services
{
    public sealed class OrderService : IOrderService
    {
<<<<<<< Updated upstream
        private IMapper mapper;
        private readonly IWorkForUnit database;

        public OrderService(IWorkForUnit database)
        {
            this.database = database;
=======
        private readonly IMapper mapper;
        private readonly IWorkForUnit database;

        public OrderService(IWorkForUnit database, IMapper mapper)
        {
            this.database = database;
            this.mapper = mapper;
>>>>>>> Stashed changes
        }

        public async Task<OrderDTO> GetAsync(int id) =>
            mapper.Map<OrderDTO>(await database.Orders.GetAsync(id));

<<<<<<< Updated upstream
        public async Task CreateAsync(OrderDTO order, GoodDTO[] goods)
        {
            database.Orders.Create(mapper.Map<Order>(order), mapper.Map<Good[]>(goods));
=======
        public async Task CreateAsync(OrderDTO order, int[] goodsid)
        {
            await database.Orders.CreateAsync(mapper.Map<Order>(order),goodsid);
>>>>>>> Stashed changes
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
