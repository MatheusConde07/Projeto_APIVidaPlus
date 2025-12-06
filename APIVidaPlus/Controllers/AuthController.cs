using APIVidaPlus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


[Route("api/auth")]
[ApiController]
public class AuthController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginDto login)
    {
        // Usuário genérico para demonstração.
        if (login.UserName == "admin" && login.Senha == "1234")
        {
            var token = GerarToken(login.UserName);
            return Ok(new { token = token });
        }
        return Unauthorized();
    }

    private string GerarToken(string username)
    {
        var key = Encoding.ASCII.GetBytes("ChaveSecretaParaOTrabalhoDaFaculadadeUninter"); // 32 ou mais caracteres
        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, username) }),
            Expires = DateTime.UtcNow.AddHours(2),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}