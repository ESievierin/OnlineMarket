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

        public virtual Order Order { get; set; }

        public virtual Goods Goods { get; set; }

    }
}
