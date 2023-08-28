namespace OnlineMarket.DAL.Interfaces
{
    public interface IWorkUnit
    {
        ICustomerRepository Customers { get; }

        IGoodRepository Goods { get; }

        IOrderRepository Orders { get; }

        void Save();


    }
}
