using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.DAL.Entities
{
    public sealed class Customer
    {

        public int Id { get; set; }

        [MaxLength(20)]
        public string FirstName { get; set; }

        [MaxLength(20)]
        public string SecondName { get; set; }

        public byte Age { get; set; }

        [MaxLength(30)]
        public string Email {get; set; }

        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
