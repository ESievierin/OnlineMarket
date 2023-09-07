using OnlineMarket.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.BLL.Interfaces
{
    public interface ICustomerService
    {
        CustomerDTO Get(int id);

        void Create(CustomerDTO customer);

        void Update(CustomerDTO newCustomer);

        void Delete(int id);
    }
}
