using CustomerWebAPI.Adapters.Persistence.Models;
using CustomerWebAPI.Adapters.Web.Security;
using log4net;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace RestaurantsBackEnd.Adapters.Web.Controllers.Login
{
    [Route("/api/restaurant/v1.0/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(LoginController));
        [HttpPost]
        public IActionResult Post([FromBody] LoginDTO loginDTO)
        {
            try
            {
                if (SecurityTokenUtil.IsValidUser(loginDTO))
                {
                    return Ok(new JwtSecurityTokenHandler().
                    WriteToken(SecurityTokenUtil.GetJwtSecurityToken()));
                }
            }
            catch (Exception ex)
            {
                log.Error($"An error occurred in generating the token: {ex.Message}");
                return BadRequest("An error occurred in generating the token");
            }
            log.Error("Is not a valid user");
            return Unauthorized();
        }
    }
}
