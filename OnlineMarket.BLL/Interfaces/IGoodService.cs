using OnlineMarket.BLL.DTO;

namespace OnlineMarket.BLL.Interfaces
{
    public interface IGoodService 
    {
        Task<GoodDTO[]> GetAllAsync();

        Task<GoodDTO> GetAsync(int id);

        Task CreateAsync(GoodDTO Good);

        Task UpdateAsync(GoodDTO newGood);

        Task DeleteAsync(int id);
    }
}
