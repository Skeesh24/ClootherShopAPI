
using ClootherShopAPI.DAL.Context;
using ClootherShopAPI.DAL.Entities;
using ClootherShopAPI.DAL.Interfaces;

namespace ClootherShopAPI.DAL.Repositories;

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

    public IEnumerable<ReplyEntity>? GetAll()
    {
        var res = db.Replies.ToList();
        if (res is null)
            throw new NullReferenceException();
        return res;
    }

    public void Update(ReplyEntity item)
    {
        db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    }
}
