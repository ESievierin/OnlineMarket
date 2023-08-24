using OnlineMarket.DAL.Entities;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public DateTimeOffset OrderDate { get; set; }

        public DateTimeOffset CompletionDate { get; set; }



        public virtual Customer Customer { get; set; }
    }
}
