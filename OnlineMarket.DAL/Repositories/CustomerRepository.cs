using Microsoft.EntityFrameworkCore;
using OnlineMarket.DAL.EF;
using OnlineMarket.DAL.Entities;
using OnlineMarket.DAL.Interfaces;

namespace OnlineMarket.DAL.Repositories
{
    public sealed class CustomerRepository : ICustomerRepository
    {
        private readonly OnlineMarketContext db;

        public CustomerRepository(OnlineMarketContext db)
        {
            this.db = db;
        }

        public async Task<Customer> GetAsync(int id) =>
           await db.Customers.FindAsync(id);

        public void Update(Customer newCustomer) =>
            db.Customers.Update(newCustomer);
        

        public void Create(Customer customer) =>
            db.Customers.Add(customer);
         
        public async Task DeleteAsync(int id)
        {
            var customer = await db.Customers.FindAsync(id);

            if(customer != null) 
                db.Customers.Remove(customer);
        }  
    }
}
