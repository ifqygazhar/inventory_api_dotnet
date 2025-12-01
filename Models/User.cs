using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

[Index(nameof(Username), IsUnique = true)]
[Index(nameof(Email), IsUnique = true)]
public class User
{

    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    public Guid? AssignedWarehouseId { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? LastLogin { get; set; }

    public required ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();

}