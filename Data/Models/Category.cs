using System.ComponentModel.DataAnnotations.Schema;

namespace Mobioko.Data.Models;

public class Category : BaseEntity<int>
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    [NotMapped]
    public int ProductsCount { get; set; }

    override public string ToString() => Name;
}