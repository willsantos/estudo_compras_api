namespace Wilson.Compras.Api.Models;

public class ListItem
{
    public int Id { get; set; }

    public int ListId { get; set; }

    public int ItemId { get; set; }

    public bool Purchase { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public ShopList ShopList { get; set; }

    public Item Item { get; set; }
}