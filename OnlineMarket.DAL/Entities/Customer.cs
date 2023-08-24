using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.DAL.Entities
{
    public sealed class Customer
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public int Age { get; set; }
        
        public string Email {get; set; }

        public string PhoneNumber { get; set; }
    }
}
