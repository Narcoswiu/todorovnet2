using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace TodorovNET.API.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IConfiguration _cfg;

    public AuthController(IConfiguration cfg) => _cfg = cfg;

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginDto dto)
    {
        var user = _cfg["Admin:Username"];
        var pass = _cfg["Admin:Password"];

        if (dto.Username != user || dto.Password != pass)
            return Unauthorized(new { error = "Грешно потребителско име или парола." });

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_cfg["Jwt:Key"]!));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: _cfg["Jwt:Issuer"],
            audience: _cfg["Jwt:Audience"],
            claims: new[] { new Claim(ClaimTypes.Name, user!) },
            expires: DateTime.UtcNow.AddHours(12),
            signingCredentials: creds
        );

        return Ok(new {
            token = new JwtSecurityTokenHandler().WriteToken(token),
            expires = token.ValidTo,
            username = user
        });
    }
}

public record LoginDto(string Username, string Password);
