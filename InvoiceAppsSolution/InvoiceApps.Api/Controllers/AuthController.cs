
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using InvoiceApps.Api.Models;
using System.ComponentModel.DataAnnotations;

namespace InvoiceApps.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _um;
        private readonly SignInManager<ApplicationUser> _sm;

        public AuthController(UserManager<ApplicationUser> um, SignInManager<ApplicationUser> sm)
        {
            _um = um; _sm = sm;
        }

        public class RegisterDto { [Required] public string Email { get; set; } = null!; [Required] public string Password { get; set; } = null!; public string? FullName { get; set; } }
        public class LoginDto { [Required] public string Email { get; set; } = null!; [Required] public string Password { get; set; } = null!; }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto dto)
        {
            var user = new ApplicationUser { UserName = dto.Email, Email = dto.Email, FullName = dto.FullName };
            var res = await _um.CreateAsync(user, dto.Password);
            if (!res.Succeeded) return BadRequest(res.Errors);
            return Ok(new { Message = "Registered" });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto dto)
        {
            var res = await _sm.PasswordSignInAsync(dto.Email, dto.Password, isPersistent: false, lockoutOnFailure: false);
            if (!res.Succeeded) return BadRequest(new { Message = "Invalid credentials" });
            return Ok(new { Message = "LoggedIn" });
        }
    }
}
