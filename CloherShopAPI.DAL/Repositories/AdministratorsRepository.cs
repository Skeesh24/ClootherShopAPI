﻿
using ClootherShopAPI.DAL.Context;
using ClootherShopAPI.DAL.Entities;
using ClootherShopAPI.DAL.Interfaces;

namespace ClootherShopAPI.DAL.Repositories;

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

    public IEnumerable<AdministratorEntity>? GetAll()
    {
        var res = db.Administrators.ToList();
        if (res is null)
            throw new NullReferenceException();
        return res;
    }

    public void Update(AdministratorEntity item)
    {
        db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    }
}
