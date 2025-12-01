using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Index(nameof(Sku), IsUnique = true)]
public class Product
{
    public int Id { get; set; }
    public string Sku { get; set; } = string.Empty;
    [Required]
    [StringLength(100, MinimumLength = 2)]
    public string Name { get; set; } = string.Empty;
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
    public int CategoryId { get; set; }

    public Category Category { get; set; } = null!;
    public ICollection<Stock> Stocks { get; set; } = new HashSet<Stock>();
}