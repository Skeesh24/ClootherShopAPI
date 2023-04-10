using ClootherShopAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClootherShopAPI.DAL.Context
{
    public class DataContext : DbContext
    {

        public DbSet<ClientEntity> Clients { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<PaymentEntity> Payments { get; set; }
        public DbSet<AdministratorEntity> Administrators { get; set; }
        public DbSet<ProductCategoryEntity> Categories { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ReplyEntity> Replies { get; set; }

        private string str;

        public DataContext(string connectionString) : base()
        {
            str = connectionString;
            Database.EnsureCreatedAsync();
            Database.EnsureDeletedAsync();
        }

        //public DataContext(DbContextOptions<DataContext> options) : base(options)
        //{
            
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(str);
        }


    }
}
