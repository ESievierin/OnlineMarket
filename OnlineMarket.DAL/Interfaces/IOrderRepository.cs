using OnlineMarket.DAL.Entities;

namespace OnlineMarket.DAL.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order> GetAsync(int id);

        Task CreateAsync(Order Order, int[] goodsid);
        
        void Update(Order newOrder);

        Task DeleteAsync(int id);
    }
}
