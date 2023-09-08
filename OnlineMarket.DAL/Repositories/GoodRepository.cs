using Microsoft.EntityFrameworkCore;
using OnlineMarket.DAL.EF;
using OnlineMarket.DAL.Entities;
using OnlineMarket.DAL.Interfaces;


namespace OnlineMarket.DAL.Repositories
{
    public sealed class GoodRepository : IGoodRepository
    {
        private readonly OnlineMarketContext db;

        public GoodRepository(OnlineMarketContext db)
        {
            this.db = db;
        }

        public async Task<Good[]> GetAllAsync() =>
            await db.Goods.ToArrayAsync();

        public async Task<Good> GetAsync(int id) =>
            await db.Goods.FindAsync(id);

        public void Create(Good good)=>
            db.Goods.Add(good);

        public void Update(Good newGood) =>
            db.Goods.Update(newGood);
        
        public async Task DeleteAsync(int id)
        {
            var good = await db.Goods.FindAsync(id);

            if(good != null)
                db.Goods.Remove(good);
        }    
    }
}
