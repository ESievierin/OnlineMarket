using AutoMapper;
using OnlineMarket.BLL.DTO;
using OnlineMarket.DAL.Entities;
using OnlineMarket.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.BLL.Services
{
    public sealed class GoodService
    {
        private readonly IWorkUnit Database;
        private IMapper mapper;

        public GoodService(IWorkUnit database) 
        {
            Database = database;
        }

        public GoodDTO[] GetAll() =>
            mapper.Map<GoodDTO[]>(Database.Goods.GetAll());

        public GoodDTO Get(int id) =>
            mapper.Map<GoodDTO>(Database.Goods.Get(id));

        public void Update(GoodDTO newGood)
        {
            var data = Database.Goods.Get(newGood.Id);

            if(data != null)
            {
                Database.Goods.Update(mapper.Map<Good>(newGood));
                Database.Save();
            }
        }

        public void Delete(int id)
        {      
            Database.Goods.Delete(id);
            Database.Save();
        }
        
    }
}
