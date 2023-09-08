using OnlineMarket.DAL.Entities;

namespace OnlineMarket.DAL.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order> GetAsync(int id);

        void Create(Order Order, Good[] goods);
        
        void Update(Order newOrder);

        Task DeleteAsync(int id);
    }
}
