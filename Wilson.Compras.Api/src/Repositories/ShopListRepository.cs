using Wilson.Compras.Api.Data;
using Wilson.Compras.Api.Models;

namespace Wilson.Compras.Api.Repositories;

public class ShopListRepository: BaseRepository<ShopList>
{
    public ShopListRepository(AppDbContext context) : base(context)
    {
    }
}