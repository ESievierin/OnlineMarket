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

        public IEnumerable<Good> GetAll() =>
            db.Goods;

        public async Task<Good> Get(int id) =>
           await db.Goods.FindAsync(id);

        public void Create(Good good)=>
            db.Goods.AddAsync(good);

        public void Update( Good newGood)
        {
            db.Entry(newGood).State = EntityState.Modified;
            db.Goods.Update(newGood);
        }

        public async Task Delete(int id)
        {
            var data = await  db.Goods.FindAsync(id);
            if (data != null)
                db.Goods.Remove(data);         
        }
    }
}
