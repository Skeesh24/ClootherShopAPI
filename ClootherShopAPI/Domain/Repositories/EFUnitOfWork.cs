
using ClootherShopAPI.Domain.Context;
using ClootherShopAPI.Domain.Entities;
using ClootherShopAPI.Domain.Interfaces;

namespace ClootherShopAPI.Domain.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private DataContext db;
        private OrdersRepository ordersRepository;
        private ProductsRepository productsRepository;
        private CategoriesRepository categoriesRepository;
        private ClientsRepository clientsRepository;
        private RepliesRepository repliesRepository;
        private AdministratorsRepository administratorsRepository;
        private PaymentsRepository paymentsRepository;

        public EFUnitOfWork(string connectionString)
        {
            db = new DataContext(connectionString);
        }

        public IRepository<ClientEntity> Clients
        {
            get
            {
                if (clientsRepository == null)
                    clientsRepository = new ClientsRepository(db);
                return clientsRepository;
            }
        }

        public IRepository<OrderEntity> Orders
        {
            get
            {
                if(ordersRepository == null)
                    ordersRepository = new OrdersRepository(db);
                return ordersRepository;
            }
        }

        public IRepository<ProductEntity> Products
        {
            get
            {
                if(productsRepository == null)
                    productsRepository = new ProductsRepository(db);
                return productsRepository;
            }
        }

        public IRepository<ReplyEntity> Replies
        {
            get
            {
                if(repliesRepository == null)
                    repliesRepository = new RepliesRepository(db);
                return repliesRepository;
            }
        }

        public IRepository<ProductCategoryEntity> Categories
        {
            get
            {
                if (categoriesRepository == null)
                    categoriesRepository = new CategoriesRepository(db);    
                return categoriesRepository;
            }
        }

        public IRepository<PaymentEntity> Payments
        {
            get
            {
                if(paymentsRepository == null)
                    paymentsRepository = new PaymentsRepository(db);
                return paymentsRepository;
            }
        }

        public IRepository<AdministratorEntity> Administrators
        {
            get
            {
                if(administratorsRepository == null)    
                    administratorsRepository = new AdministratorsRepository(db);
                return administratorsRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }


        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
