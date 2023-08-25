using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMarket.DAL.Entities;

namespace OnlineMarket.DAL.Entities
{
    public class OrderGoods
    {

        public int OrderId { get; set; }
        public int GoodId { get; set; }
        public  Order Order { get; set; } = null!;

        public Good Good { get; set; } = null!;

    }
}
