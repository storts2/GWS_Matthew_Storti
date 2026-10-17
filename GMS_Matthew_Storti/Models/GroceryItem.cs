using System.ComponentModel.DataAnnotations;

namespace GMS_Matthew_Storti.Models;

public class GroceryItem
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    [MaxLength(20)]
    public string? Category { get; set; }

    [Required]
    [MinLength(10)]
    [MaxLength(10)]
    public string? Date { get; set; }

    [Required]
    [Range(0, 100)]
    public int? Quantity { get; set; }

    [Required]
    [Range(0.0, 1000.0)]
    public double? Price { get; set; }
}
