using ClootherShopAPI.Domain.Entities;

namespace ClootherShopAPI.Domain.Interfaces;

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
