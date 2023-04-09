
using ClootherShopAPI.Domain.Context;
using ClootherShopAPI.Domain.Entities;
using ClootherShopAPI.Domain.Interfaces;

namespace ClootherShopAPI.Domain.Repositories;

public class AdministratorsRepository : IRepository<AdministratorEntity>
{
    private DataContext db;

    public AdministratorsRepository(DataContext db)
    {
        this.db = db;
    }

    public void Create(AdministratorEntity item)
    {
        db.Administrators.Add(item);
    }

    public void Delete(AdministratorEntity item)
    {
        db.Administrators.Remove(item);
    }

    public void DeleteRange(IEnumerable<AdministratorEntity> items)
    {
        db.Administrators.RemoveRange(items);
    }

    public AdministratorEntity? Get(int id)
    {
        return db.Administrators.Find(id);
    }

    public IEnumerable<AdministratorEntity>? GetAll(Func<AdministratorEntity, bool> predicate)
    {
        return db.Administrators.Where(predicate);
    }

    public void Update(AdministratorEntity item)
    {
        db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    }
}
