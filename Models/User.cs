using Microsoft.AspNetCore.Identity;

public class User : IdentityUser
{
    public string FullName { get; set; } = string.Empty;

    public Guid? AssignedWarehouseId { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? LastLogin { get; set; }
}