using CustomerWebAPI.Adapters.Persistence.Models;
using CustomerWebAPI.Adapters.Web.Security;
using log4net;
using System.IdentityModel.Tokens.Jwt;

namespace CustomerWebAPI.Adapters.Web.Controllers.Login
{
    public static class LoginController
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(LoginController));
        public static void MapLoginEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("/api/restaurent/v1.0/login").WithTags(nameof(Login));

            group.MapPost("/", (LoginDTO loginDTO) =>
            {
                try
                {
                    if (SecurityTokenUtil.IsValidUser(loginDTO))
                    {
                        return Results.Ok(new JwtSecurityTokenHandler().
                        WriteToken(SecurityTokenUtil.GetJwtSecurityToken()));
                    }
                }
                catch (Exception ex)
                {
                    log.Error($"An error occurred in generating the token: {ex.Message}");
                    return Results.BadRequest("An error occurred in generating the token");
                }
                log.Error("Is not a valid user");
                return Results.Unauthorized();
            })
            .WithName("CreateLogin")
            .WithOpenApi();
        }
    }
}
