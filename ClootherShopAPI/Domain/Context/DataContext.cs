using ClootherShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClootherShopAPI.Domain.Context
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

        public DataContext(string connectionString)
        {
            str = connectionString;
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreatedAsync();
            Database.EnsureDeletedAsync();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(str);
        }


    }
}
