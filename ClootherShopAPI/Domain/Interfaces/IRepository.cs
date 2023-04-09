namespace ClootherShopAPI.Domain.Interfaces;

public interface IRepository<T> where T : class
{
    T? Get(int id);
    IEnumerable<T>? GetAll(Func<T, Boolean> predicate);
    void Create(T item);
    void Update(T item);
    void Delete(T item);
    void DeleteRange(IEnumerable<T> items);
}
