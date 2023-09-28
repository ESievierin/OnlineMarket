using OnlineMarket.BLL.DTO;

namespace OnlineMarket.BLL.Interfaces
{
    public interface IOrderService
    {
        Task<OrderDTO> GetAsync(int id);

<<<<<<< Updated upstream
        Task CreateAsync(OrderDTO order, GoodDTO[] goods);
=======
        Task CreateAsync(OrderDTO order, int[] goodsid);
>>>>>>> Stashed changes

        Task UpdateAsync(OrderDTO newOrder);

        Task DeleteAsync(int id);
    }
}
