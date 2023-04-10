namespace ClootherShopAPI.DAL.Interfaces;

public interface IRepository<T> where T : class
{
    T? Get(int id);
    IEnumerable<T>? GetAll(Func<T, Boolean> predicate);
    IEnumerable<T>? GetAll();
    void Create(T item);
    void Update(T item);
    void Delete(T item);
    void DeleteRange(IEnumerable<T> items);
}
