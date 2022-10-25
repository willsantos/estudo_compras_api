using Wilson.Compras.Api.Models;
using Wilson.Compras.Api.Repositories;

namespace Wilson.Compras.Api.Services;

public class ShopListService
{
    public readonly ShopListRepository _repository;

    public ShopListService(ShopListRepository repository )
    {
        _repository = repository;
    }

    public async Task Add(ShopList item)
    {
        await _repository.AddAsync(item);
    }

    public async Task<List<ShopList>> List()
    {
        return await _repository.ListAsync();
    }

    public async Task<ShopList> Show(int shopListId)
    {
        
        return await _repository.FindAsync(shopListId);
    }
}