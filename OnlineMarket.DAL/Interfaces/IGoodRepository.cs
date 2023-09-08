using OnlineMarket.DAL.Entities;

namespace OnlineMarket.DAL.Interfaces
{
    public interface IGoodRepository
    {
        Task<Good[]> GetAllAsync();
        
        Task<Good> GetAsync(int id);

        void Create(Good good);

        void Update(Good newGood);

        Task DeleteAsync(int id);
    }
}
