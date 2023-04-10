using ClootherShopAPI.DAL.Context;
using ClootherShopAPI.DAL.Entities;
using ClootherShopAPI.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClootherShopAPI.DAL.Repositories
{
    public class CategoriesRepository : IRepository<ProductCategoryEntity>
    {
        DataContext db;

        public CategoriesRepository(DataContext db)
        {
            this.db = db;
        }


        public void Create(ProductCategoryEntity item)
        {
            db.Categories.AddAsync(item);
        }

        public void Delete(ProductCategoryEntity item)
        {
            db.Categories.Remove(item);
        }
        public void DeleteRange(IEnumerable<ProductCategoryEntity> items)
        {
            db.Categories.RemoveRange(items);
        }

        public ProductCategoryEntity? Get(int id)
        {
            return db.Categories.Find(id);    
        }

        public IEnumerable<ProductCategoryEntity> GetAll(Func<ProductCategoryEntity, bool> predicate)
        {
            return db.Categories.Where(predicate);
        }

        public IEnumerable<ProductCategoryEntity>? GetAll()
        {
            var res = db.Categories.ToList();
            if (res is null)
                throw new NullReferenceException();
            return res;
        }

        public void Update(ProductCategoryEntity item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

    }
}
