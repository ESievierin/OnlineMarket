using OnlineMarket.DAL.Entities;

namespace OnlineMarket.DAL.Interfaces
{
    public interface IGoodRepository
    {
        Task<Good[]> GetAll();
        
        Task<Good> Get(int id);

        void Create(Good good);

        void Update(Good newGood);

        Task Delete(int id);
    }
}
