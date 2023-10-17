using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace ApiSecurity.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticacionController : ControllerBase
{
    private readonly IConfiguration _config;

    public AuthenticacionController(IConfiguration config)
    {
        _config = config;
    }
    public record AuthenticacionData(string? UserName, string? Password);
    public record UserData(int UserId, string UserName);

    // api/Authenticacion/token
    [HttpPost("token")]
    public ActionResult<string> Authenticate([FromBody] AuthenticacionData data)
    {
        var user = ValidateCredentials(data);

        if (user is null)
        {
            return Unauthorized();
        }

        var token = GenerateToken(user);

        return Ok(token);
    }

    private string GenerateToken(UserData user)
    {
        var secretKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_config.GetValue<string>("Authentication:SecretKey")));

        var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

        List<Claim> claims = new List<Claim>();
        claims.Add(new(JwtRegisteredClaimNames.Sub, user.UserId.ToString()));
        claims.Add(new(JwtRegisteredClaimNames.UniqueName, user.UserName));
        var token = new System.IdentityModel.Tokens.Jwt.JwtSecurityToken(
            _config.GetValue<string>("Authentication:Issuer"),
            _config.GetValue<string>("Authentication:Audience"),
            claims,
            DateTime.UtcNow,
            DateTime.UtcNow.AddMinutes(1),
            signingCredentials);

        return new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler().WriteToken(token);

    }

    private UserData? ValidateCredentials(AuthenticacionData data)
    {
        // THIS IS NOT PRODUCTION CODE - THIS IS ONLY A DEMO - DO NOT USE IN REAL LIFE
        // SIMULATE DATABASE

        if (CompareValues(data.UserName, "tcorey") && CompareValues(data.UserName,"Test123"))
        {
            return new UserData(1,data.UserName!);
        }
        if (CompareValues(data.UserName, "sstorm") && CompareValues(data.Password, "Test123"))
        {
            return new UserData(2, data.UserName!);
        }
        return null;
    }

    private bool CompareValues(string? actual, string? expected)
    {
        if (actual is not null)
        {
            if (actual.Equals(expected))
            {
                return true;
            }
        }

        return false;
    }


}
