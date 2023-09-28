using AutoMapper;
using OnlineMarket.BLL.DTO;
using OnlineMarket.BLL.Interfaces;
using OnlineMarket.DAL.Entities;
using OnlineMarket.DAL.Interfaces;

namespace OnlineMarket.BLL.Services
{
    public sealed class GoodService : IGoodService
    {
        private readonly IWorkForUnit database;
        private readonly IMapper mapper;


        public GoodService(IWorkForUnit database)
        {
            this.database = database;
        }
        public GoodService(IWorkForUnit database, IMapper mapper ) 
        {
            this.database = database;
            this.mapper = mapper;
        }

        public async Task<GoodDTO[]> GetAllAsync() =>
            mapper.Map<GoodDTO[]>(await database.Goods.GetAllAsync());

        public async Task<GoodDTO> GetAsync(int id) =>
            mapper.Map<GoodDTO>(await database.Goods.GetAsync(id));

        public async Task CreateAsync(GoodDTO Good)
        {
            database.Goods.Create(mapper.Map<Good>(Good));
            await database.SaveAsync();
        }

        public async Task UpdateAsync(GoodDTO newGood)
        {
            database.Goods.Update(mapper.Map<Good>(newGood));
            await database.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {      
            await database.Goods.DeleteAsync(id);
            await database.SaveAsync();
        }
        
    }
}
