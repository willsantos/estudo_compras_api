namespace Wilson.Compras.Api.Interfaces;

public interface IBaseRepository<T> where T : class
{
    Task<T> FindAsync(int id);
    Task<int> CountAsync();
    Task<List<T>> ListAsync();
    Task AddAsync(T item);
    Task EditAsync(T item);
    Task RemoveAsync(T item);
}