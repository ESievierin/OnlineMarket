using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.DAL.Entities
{
    public sealed  class Goods
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public bool IsАvailable { get; set; }

        public decimal Price { get; set; }
    }
}
