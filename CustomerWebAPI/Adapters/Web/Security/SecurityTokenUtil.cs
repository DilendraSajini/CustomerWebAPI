using CustomerWebAPI.Adapters.Persistence.Models;
using CustomerWebAPI.Config;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace CustomerWebAPI.Adapters.Web.Security
{
    public static class SecurityTokenUtil
    {
        public static Boolean IsValidUser(Login loginDTO)
        {
            if (string.IsNullOrEmpty(loginDTO.UserName) ||
                               string.IsNullOrEmpty(loginDTO.Password))
            {
                return false;
            }
            else if (loginDTO.UserName.Equals(ConfigProvider.GetConfiguration("User:UserName")) &&
            loginDTO.Password.Equals(ConfigProvider.GetConfiguration("User:Password")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static JwtSecurityToken GetJwtSecurityToken()
        {
            var secretKey = ConfigProvider.GetConfiguration("Jwt:Key");
            var symmetricKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(secretKey));
            var signinCredentials = new SigningCredentials
            (symmetricKey, SecurityAlgorithms.HmacSha256);

            return new JwtSecurityToken(
                            issuer: ConfigProvider.GetConfiguration("Jwt:Issuer"),
                            audience: ConfigProvider.GetConfiguration("Jwt:Audience"),
                            claims: new List<Claim>(),
                            expires: DateTime.Now.AddMinutes(10),
                            signingCredentials: signinCredentials
                        );
        }

        public static TokenValidationParameters GetTokenValidationParameters()
        {
            return new TokenValidationParameters
            {
                ValidIssuer = ConfigProvider.GetConfiguration("Jwt:Issuer"),
                ValidAudience = ConfigProvider.GetConfiguration("Jwt:Audience"),
                IssuerSigningKey = new SymmetricSecurityKey
                    (System.Text.Encoding.UTF8.GetBytes(ConfigProvider.GetConfiguration("Jwt:Key"))),
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = false,
                ValidateIssuerSigningKey = true
            };
        }
    }
}
