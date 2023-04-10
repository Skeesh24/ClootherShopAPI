using ClootherShopAPI.DAL.Context;
using ClootherShopAPI.DAL.Entities;
using ClootherShopAPI.DAL.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ClootherShopAPI.DAL.Repositories;

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

    public IEnumerable<ClientEntity>? GetAll()
    {
        var res = db.Clients.ToList();
        if (res is null)
            throw new NullReferenceException();
        return res;
    }

    public void Update(ClientEntity item)
    {
        db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    }
}
