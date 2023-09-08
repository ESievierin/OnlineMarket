using OnlineMarket.BLL.DTO;

namespace OnlineMarket.BLL.Interfaces
{
    public interface ICustomerService
    {
        Task<CustomerDTO> GetAsync(int id);

        Task CreateAsync(CustomerDTO customer);

        Task UpdateAsync(CustomerDTO newCustomer);

        Task DeleteAsync(int id);
    }
}
