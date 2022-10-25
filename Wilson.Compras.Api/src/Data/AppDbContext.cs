using Microsoft.EntityFrameworkCore;
using Wilson.Compras.Api.Models;

namespace Wilson.Compras.Api.Data;

public class AppDbContext : DbContext
{
    
    public DbSet<Item> Items { get; set; }
    public DbSet<ShopList> Lists { get; set; }
    public DbSet<ListItem> Listitems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Server=127.0.0.1,1439;Database=compras_wilson_santos;User=SA;Password=wd%!r$H7Ez@yuPz*sx*3wUgBcwv;"
        );
    }

}