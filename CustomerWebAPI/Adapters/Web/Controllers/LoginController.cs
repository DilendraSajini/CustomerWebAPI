using CustomerWebAPI.Adapters.Persistence.Models;
using CustomerWebAPI.Config;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace CustomerWebAPI.Adapters.Web.Controllers
{
    public static class LoginController
    {
        public static void MapLoginEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("/api/Login").WithTags(nameof(Login));

            group.MapPost("/", (Login loginDTO) =>
            {
                try
                {
                    if (string.IsNullOrEmpty(loginDTO.UserName) ||
                    string.IsNullOrEmpty(loginDTO.Password))
                        return Results.BadRequest("Username and/or Password not specified");
                    if (loginDTO.UserName.Equals(ConfigProvider.GetConnectionString("User:UserName")) &&
                    loginDTO.Password.Equals(ConfigProvider.GetConnectionString("User:Password")))
                    {
                        var secretKey = ConfigProvider.GetConnectionString("Jwt:Key");
                        var symmetricKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(secretKey));
                        var signinCredentials = new SigningCredentials
                        (symmetricKey, SecurityAlgorithms.HmacSha256);

                        var jwtSecurityToken = new JwtSecurityToken(
                            issuer: ConfigProvider.GetConnectionString("Jwt:Issuer"),
                            audience: ConfigProvider.GetConnectionString("Jwt:Audience"),
                            claims: new List<Claim>(),
                            expires: DateTime.Now.AddMinutes(10),
                            signingCredentials: signinCredentials
                        );
                        return Results.Ok(new JwtSecurityTokenHandler().
                        WriteToken(jwtSecurityToken));
                    }
                }
                catch (Exception ex)
                {
                    return Results.BadRequest("An error occurred in generating the token");
                }
                return Results.Unauthorized();
            })
            .WithName("CreateLogin")
            .WithOpenApi();
        }
    }
}
