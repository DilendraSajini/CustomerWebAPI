/*using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using static System.Net.Mime.MediaTypeNames;

namespace RestaurantsBackEnd.Adapters.Web.Security
{
    public class WindowsSecurityMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _config;
        public WindowsSecurityMiddleware(RequestDelegate next, IConfiguration config)
        {
            _next = next;
            _config = config;
        }
        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path.Value != "/STS" && context.Request.Path.Value != "/Redirect") //bypass auth if going to STS as it handles its own security
            {
                string jwt = JWTHelper.AuthenticateJWT(context, _config); //do jwt auth on all other requests

                //set the context user for the rest of the chain based on the validated jwt claims
                var myTokenHandler = new JwtSecurityTokenHandler();
                JwtSecurityToken t = (JwtSecurityToken)myTokenHandler.ReadToken(jwt);
                context.User = new ClaimsPrincipal(new ClaimsIdentity(new GenericIdentity(t.Claims.Where(w => w.Type == "unique_name").Select(s => s.Value).First()), t.Claims));

            }
            await _next(context);
        }
    }
}
*/