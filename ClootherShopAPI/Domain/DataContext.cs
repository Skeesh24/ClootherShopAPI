using ClootherShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClootherShopAPI.Domain
{
    public class DataContext : DbContext
    {

        public DbSet<ClientEntity> Clients { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<PaymentEntity> Payments { get; set; }
        public DbSet<AdministratorEntity> Administrators { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ReplyEntity> Replies { get; set; }

        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreatedAsync();
            Database.EnsureDeletedAsync();   
        }   

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var str = new ConfigurationManager()
                .AddJsonFile("appsettings.json")
                .Build()
                .GetConnectionString("DefaultConnection");
            options.UseNpgsql(str);
        }


    }
}
