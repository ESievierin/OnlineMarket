using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.BLL.DTO
{
    public sealed class OrderDTO
    {
        public int Id { get; set; }
        
        public int CustomerId { get; set; }

        public DateTimeOffset OrderDate { get; set; }

        public DateTimeOffset CompletionDate { get; set; }
    }
}
