namespace Wilson.Compras.Api.Models;

public class ShopList
{
    public int Id { get; set; }

    public string Name { get; set; }

    public DateTime Date { get; set; }

    public bool Complete { get; set; } = false;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    //public IList<ListItem> List_items { get; set; }
}