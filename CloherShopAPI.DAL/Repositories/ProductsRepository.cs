﻿
using ClootherShopAPI.DAL.Context;
using ClootherShopAPI.DAL.Entities;
using ClootherShopAPI.DAL.Interfaces;

namespace ClootherShopAPI.DAL.Repositories;

public class ProductsRepository : IRepository<ProductEntity>
{
    DataContext db;

    public ProductsRepository(DataContext db)
    {
        this.db = db;
    }

    public void Create(ProductEntity item)
    {
        db.Products.Add(item);
    }

    public void Delete(ProductEntity item)
    {
        db.Products.Remove(item);
    }

    public void DeleteRange(IEnumerable<ProductEntity> items)
    {
        db.Products.RemoveRange(items);
    }

    public ProductEntity? Get(int id)
    {
        return db.Products.Find(id);
    }

    public IEnumerable<ProductEntity>? GetAll(Func<ProductEntity, bool> predicate)
    {
        return db.Products.Where(predicate);
    }

    public IEnumerable<ProductEntity>? GetAll()
    {
        var res = db.Products.ToList();
        if (res is null)
            throw new NullReferenceException();
        return res;
    }

    public void Update(ProductEntity item)
    {
        db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    }
}
