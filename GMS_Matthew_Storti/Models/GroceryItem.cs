using System.ComponentModel.DataAnnotations;

namespace GMS_Matthew_Storti.Models;

public class GroceryItem
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Category { get; set; }
    public string? Date { get; set; }
    public int? Quantity { get; set; }
    public double? Price { get; set; }
}
