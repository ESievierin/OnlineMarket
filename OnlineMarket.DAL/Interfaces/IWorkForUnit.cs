namespace OnlineMarket.DAL.Interfaces
{
    public interface IWorkForUnit
    {
        ICustomerRepository Customers { get; }

        IGoodRepository Goods { get; }

        IOrderRepository Orders { get; }

        Task SaveAsync();
    }
}
