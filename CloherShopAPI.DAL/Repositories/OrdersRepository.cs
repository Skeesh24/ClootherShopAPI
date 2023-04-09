
using ClootherShopAPI.DAL.Context;
using ClootherShopAPI.DAL.Entities;
using ClootherShopAPI.DAL.Interfaces;

namespace ClootherShopAPI.DAL.Repositories;

public class OrdersRepository : IRepository<OrderEntity>
{
    DataContext db;

    public OrdersRepository(DataContext db)
    {
        this.db = db;
    }

    public void Create(OrderEntity item)
    {
        db.Orders.Add(item);
    }

    public void Delete(OrderEntity item)
    {
        db.Orders.Remove(item);
    }

    public void DeleteRange(IEnumerable<OrderEntity> items)
    {
        db.Orders.RemoveRange(items);
    }

    public OrderEntity? Get(int id)
    {
        return db.Orders.Find(id);
    }

    public IEnumerable<OrderEntity>? GetAll(Func<OrderEntity, bool> predicate)
    {
        return db.Orders.Where(predicate);
    }

    public void Update(OrderEntity item)
    {
        db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    }
}
