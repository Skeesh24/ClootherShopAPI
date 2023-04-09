using ClootherShopAPI.DAL.Entities;

namespace ClootherShopAPI.DAL.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IRepository<ClientEntity> Clients { get; }
    IRepository<OrderEntity> Orders { get; }
    IRepository<ProductEntity> Products { get; }
    IRepository<ReplyEntity> Replies { get; }
    IRepository<ProductCategoryEntity> Categories { get; }
    IRepository<PaymentEntity> Payments { get; }
    IRepository<AdministratorEntity> Administrators { get; }
    void Save();
}
