using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.DAL.Entities
{
    public sealed  class Good
    {

        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }

        public bool IsАvailable { get; set; }

        public decimal Price { get; set; }
        
    }
}
