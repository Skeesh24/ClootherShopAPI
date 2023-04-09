
using ClootherShopAPI.Domain.Context;
using ClootherShopAPI.Domain.Entities;
using ClootherShopAPI.Domain.Interfaces;

namespace ClootherShopAPI.Domain.Repositories;

public class PaymentsRepository : IRepository<PaymentEntity>
{
    private DataContext db;

    public PaymentsRepository(DataContext db)
    {
        this.db = db;
    }

    public void Create(PaymentEntity item)
    {
        db.Payments.Add(item);
    }

    public void Delete(PaymentEntity item)
    {
        db.Payments.Remove(item);
    }

    public void DeleteRange(IEnumerable<PaymentEntity> items)
    {
        db.Payments.RemoveRange(items);
    }

    public PaymentEntity? Get(int id)
    {
        return db.Payments.Find(id);
    }

    public IEnumerable<PaymentEntity>? GetAll(Func<PaymentEntity, bool> predicate)
    {
        return db.Payments.Where(predicate);
    }

    public void Update(PaymentEntity item)
    {
        db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    }
}
