using AutoMapper;
using OnlineMarket.BLL.DTO;
using OnlineMarket.BLL.Interfaces;
using OnlineMarket.DAL.Entities;
using OnlineMarket.DAL.Interfaces;

namespace OnlineMarket.BLL.Services
{
    public sealed class GoodService : IGoodService
    {
        private readonly IWorkForUnit Database;
        private readonly IMapper mapper;

        public GoodService(IWorkForUnit database) 
        {
            Database = database;
        }

        public async Task<GoodDTO[]> GetAllAsync() =>
            mapper.Map<GoodDTO[]>(await Database.Goods.GetAllAsync());

        public async Task<GoodDTO> GetAsync(int id) =>
            mapper.Map<GoodDTO>(await Database.Goods.GetAsync(id));

        public async Task CreateAsync(GoodDTO Good)
        {
            Database.Goods.Create(mapper.Map<Good>(Good));
            await Database.SaveAsync();
        }

        public async Task UpdateAsync(GoodDTO newGood)
        {
            var data = await Database.Goods.GetAsync(newGood.Id);

            if(data != null)
            {
                Database.Goods.Update(mapper.Map<Good>(newGood));
                await Database.SaveAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {      
            await Database.Goods.DeleteAsync(id);
            await Database.SaveAsync();
        }
        
    }
}
