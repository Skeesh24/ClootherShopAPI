
using ClootherShopAPI.Domain.Context;
using ClootherShopAPI.Domain.Entities;
using ClootherShopAPI.Domain.Interfaces;

namespace ClootherShopAPI.Domain.Repositories;

public class RepliesRepository : IRepository<ReplyEntity>
{
    DataContext db;

    public RepliesRepository(DataContext db)
    {
        this.db = db;
    }

    public void Create(ReplyEntity item)
    {
        db.Replies.Add(item);
    }

    public void Delete(ReplyEntity item)
    {
        db.Replies.Remove(item); 
    }

    public void DeleteRange(IEnumerable<ReplyEntity> items)
    {
        db.Replies.RemoveRange(items);
    }

    public ReplyEntity? Get(int id)
    {
        return db.Replies.Find(id);
    }

    public IEnumerable<ReplyEntity>? GetAll(Func<ReplyEntity, bool> predicate)
    {
        return db.Replies.Where(predicate);
    }

    public void Update(ReplyEntity item)
    {
        db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    }
}
