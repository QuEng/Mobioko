using System.ComponentModel.DataAnnotations.Schema;

namespace Mobioko.Data.Models;

public class Product : BaseEntity<int>
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    [NotMapped]
    public Category Category { get; set; } = new();
    public int? ManufacturerId { get; set; } = null!;
    [NotMapped]
    public Manufacturer Manufacturer { get; set; } = new();
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}