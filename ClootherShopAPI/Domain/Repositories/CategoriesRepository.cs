using ClootherShopAPI.Domain.Context;
using ClootherShopAPI.Domain.Entities;
using ClootherShopAPI.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClootherShopAPI.Domain.Repositories
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

        public void Update(ProductCategoryEntity item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

    }
}
