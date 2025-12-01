using System.ComponentModel.DataAnnotations;

public class Warehouse
{
    public int Id { get; set; }
    [Required]
    [StringLength(200, MinimumLength = 4)]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Location { get; set; } = string.Empty;
    public ICollection<Stock> Stocks { get; set; } = new HashSet<Stock>();
}