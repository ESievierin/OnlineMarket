using OnlineMarket.DAL.Entities;

namespace OnlineMarket.DAL.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> GetAsync(int id);

        void Create(Customer customer);

        void Update(Customer newCustomer);

        Task DeleteAsync(int id);
    }
}
