using System.ComponentModel.DataAnnotations;

namespace Inventory.Models.DTO
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "Email must be provided")]
        [EmailAddress(ErrorMessage = "Email format is not valid")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password must be provided")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
        public string Password { get; set; } = string.Empty;

        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [Required(ErrorMessage = "Confirm password must be provided")]
        [MinLength(8, ErrorMessage = "Confirm password must be at least 8 characters long")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "Full name must be provided")]
        public string FullName { get; set; } = string.Empty;

        // RoleName opsional, kalau kosong nanti di-set default di Controller
        public string? RoleName { get; set; }
    }
}