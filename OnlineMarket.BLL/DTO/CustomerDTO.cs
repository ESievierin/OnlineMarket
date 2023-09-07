using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.BLL.DTO
{
    public sealed class CustomerDTO
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public byte Age { get; set; }

        public string Email { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;
    }
}
