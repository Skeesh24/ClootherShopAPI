using ClootherShopAPI.Domain.Context;
using ClootherShopAPI.Domain.Entities;
using ClootherShopAPI.Domain.Interfaces;

namespace ClootherShopAPI.Domain.Repositories;

public class ClientsRepository : IRepository<ClientEntity>
{
    DataContext db;

    public ClientsRepository(DataContext db)
    {
        this.db = db;
    }

    public void Create(ClientEntity item)
    {
        db.Clients.Add(item);
    }

    public void Delete(ClientEntity item)
    {
        db.Clients.Remove(item);
    }

    public void DeleteRange(IEnumerable<ClientEntity> items)
    {
        db.Clients.RemoveRange(items);
    }

    public ClientEntity? Get(int id)
    {
        return db.Clients.Find(id);
    }

    public IEnumerable<ClientEntity>? GetAll(Func<ClientEntity, bool> predicate)
    {
        return db.Clients.Where(predicate);
    }

    public void Update(ClientEntity item)
    {
        db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    }
}
