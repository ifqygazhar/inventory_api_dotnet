using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Inventory.Models.DTO;

namespace Inventory.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;

        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDTO registerDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var userExists = await _userManager.FindByEmailAsync(registerDto.Email);
            if (userExists != null) return BadRequest(new { message = "User already exists" });

            var user = new User
            {
                UserName = registerDto.Email,
                Email = registerDto.Email,
                FullName = registerDto.FullName,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var result = await _userManager.CreateAsync(user, registerDto.Password);
            if (!result.Succeeded) return BadRequest(new { message = "User creation failed", errors = result.Errors });

            string roleToAssign = string.IsNullOrEmpty(registerDto.RoleName) ? "WarehouseStaff" : registerDto.RoleName;
            await _userManager.AddToRoleAsync(user, roleToAssign);

            return Ok(new { Message = "User created successfully!" });
        }
    }
}