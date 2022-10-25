using Microsoft.EntityFrameworkCore;
using Wilson.Compras.Api.Data;
using Wilson.Compras.Api.Interfaces;

namespace Wilson.Compras.Api.Repositories;

public abstract class BaseRepository<T>: IBaseRepository<T> where T:class
{
    private readonly AppDbContext _context;
    
    public BaseRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<T> FindAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task<int> CountAsync()
    {
        return await _context.Set<T>().CountAsync();
    }

    public async Task<List<T>> ListAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task AddAsync(T item)
    {
        await _context.Set<T>().AddAsync(item);
        await _context.SaveChangesAsync();
    }

    public async Task EditAsync(T item)
    {
        _context.Entry(item).State = EntityState.Modified;
        //_context.Update(item);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveAsync(T item)
    {
        _context.Set<T>().Remove(item);
        await _context.SaveChangesAsync();
    }
}