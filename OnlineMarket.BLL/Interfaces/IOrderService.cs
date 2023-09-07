using OnlineMarket.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.BLL.Interfaces
{
    public interface IOrderService
    {
        OrderDTO Get(int id);

        void Create(OrderDTO order, GoodDTO[] goods);

        void Update(OrderDTO newOrder);

        void Delete(int id);
    }
}
