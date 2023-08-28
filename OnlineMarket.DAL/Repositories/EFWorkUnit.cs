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
            get
            {

                if(customerRepository == null)
                {
                    customerRepository = new CustomerRepository(db);
                }

                return customerRepository;
            }
        }

        public IOrderRepository Orders
        {
            get
            {

                if (orderRepository == null)
                {
                    orderRepository = new OrderRepository(db);
                }

                return orderRepository;
            }
        }

        public IGoodRepository Goods
        {
            get
            {

                if (goodRepository == null)
                {
                    goodRepository = new GoodRepository(db);
                }

                return goodRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }


    }
}
