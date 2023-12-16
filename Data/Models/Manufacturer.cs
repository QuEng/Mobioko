namespace Mobioko.Data.Models;

public class Manufacturer : BaseEntity<int>
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;

    public override string ToString() => Name;
}