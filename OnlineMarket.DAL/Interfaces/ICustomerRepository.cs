using OnlineMarket.DAL.Entities;

namespace OnlineMarket.DAL.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> Get(int id);

        void Create(Customer customer);

        void Update(Customer newCustomer);

        Task Delete(int id);
    }
}
