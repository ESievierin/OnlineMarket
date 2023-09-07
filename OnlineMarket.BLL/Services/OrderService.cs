using AutoMapper;
using OnlineMarket.BLL.DTO;
using OnlineMarket.DAL.Entities;
using OnlineMarket.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.BLL.Services
{
    public sealed class OrderService
    {
        private IMapper mapper;
        private IWorkUnit Database;

        public OrderService(IWorkUnit database)
        {
            Database = database;
        }

        public OrderDTO Get(int id) =>
            mapper.Map<OrderDTO>(Database.Orders.Get(id));

        public void Create(OrderDTO orderDTO, GoodDTO[] goods)
        {
            Database.Orders.Create(mapper.Map<Order>(orderDTO), mapper.Map<Good[]>(goods));
            Database.Save();
        }

        public void Delete(int id)
        {
            Database.Orders.Delete(id);
            Database.Save();
        }

        public void Update(OrderDTO newOrder)
        {
            var order = Database.Orders.Get(newOrder.Id);

            if(order != null)
            {
                Database.Orders.Update(mapper.Map<Order>(newOrder));
                Database.Save();
            }
        }   
    }
}
