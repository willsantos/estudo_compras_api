using System.ComponentModel.DataAnnotations;

namespace Wilson.Compras.Api.Models;

public class Item
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string? Brand { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public IList<ListItem> List_items { get; set; }
}