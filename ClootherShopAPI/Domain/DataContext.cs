using ClootherShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClootherShopAPI.Domain
{
    public class DataContext : DbContext
    {

        public DbSet<ReplyEntity> Replies { get; set; }

        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseNpgsql("Server=localhost;Port=5432;Database=CloothersDB;User Id=postgres;Password=RESTFULapi_Olymp-18$");
            }
        }


    }
}
