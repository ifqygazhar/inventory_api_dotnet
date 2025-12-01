using System.ComponentModel.DataAnnotations;

namespace Inventory.Models.DTO
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Email must be provided")]
        [EmailAddress(ErrorMessage = "Email format is not valid")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Password must be provided")]
        public string Password { get; set; } = string.Empty;
    }
}