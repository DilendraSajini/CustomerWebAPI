using CustomerWebAPI.Adapters.Persistence.Models;
using CustomerWebAPI.Config;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace CustomerWebAPI.Adapters.Web.Security
{
    public static class BasicSecurityUtil
    {
        public static Boolean IsValidBasicCredentials(LoginDTO loginDTO)
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
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(Base64Decode(ConfigProvider.GetConfiguration("Jwt:Key")));
            RsaSecurityKey signingKey = new RsaSecurityKey(rsa);

            return new TokenValidationParameters
            {
                ValidIssuer = ConfigProvider.GetConfiguration("Jwt:Issuer"),
                ValidAudience = ConfigProvider.GetConfiguration("Jwt:Audience"),
                IssuerSigningKey = signingKey,
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = false,
                ValidateIssuerSigningKey = true
            };
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
