using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using OnlineMarket.BLL.DTO;
using OnlineMarket.DAL.Entities;
using OnlineMarket.DAL.Interfaces;

namespace OnlineMarket.BLL.Services
{
    public sealed class CustomerService
    {
        private IMapper mapper;
        private readonly IWorkUnit Database;
        
        public CustomerService(IWorkUnit database)
        {
            Database = database;
        }

        public CustomerDTO Get(int id) =>
              mapper.Map<CustomerDTO>( Database.Customers.Get(id));

        public void Create(CustomerDTO customer)
        {
            Database.Customers.Create(mapper.Map<Customer>(customer));
            Database.Save();
        }

        public void Update(CustomerDTO newcustomer)
        {
            var data = Database.Customers.Get(newcustomer.Id);

            if(data != null)
            {
                Database.Customers.Update(mapper.Map<Customer>(newcustomer));
                Database.Save();
            }     
        }

        public void Delete(int id) =>      
            Database.Customers.Delete(id);
    }
}
