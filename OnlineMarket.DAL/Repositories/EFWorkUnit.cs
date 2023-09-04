using OnlineMarket.DAL.EF;
using OnlineMarket.DAL.Interfaces;

namespace OnlineMarket.DAL.Repositories
{
    public sealed class EFWorkUnit : IWorkUnit 
    {
        private readonly OnlineMarketContext db;
        private ICustomerRepository customerRepository;
        private IGoodRepository goodRepository;
        private IOrderRepository orderRepository;

        public EFWorkUnit()
        {
            db = new OnlineMarketContext();
        }

        public ICustomerRepository Customers
        {
            get =>   
                customerRepository ??= new CustomerRepository(db);
            
        }

        public IOrderRepository Orders
        {
            get =>
                orderRepository ??= new OrderRepository(db);
            
        }

        public IGoodRepository Goods
        {
            get =>
                goodRepository ??= new GoodRepository(db);
           
        }

        public async Task Save()
        {
            await db.SaveChangesAsync();
        }
    }
}
