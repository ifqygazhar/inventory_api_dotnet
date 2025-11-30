using System.ComponentModel.DataAnnotations;

public class Category
{
    public int Id { get; set; }
    [Required]
    [StringLength(8, MinimumLength = 2)]
    public string Name { get; set; } = string.Empty;
    public required ICollection<Product> Products { get; set; } = [];

}