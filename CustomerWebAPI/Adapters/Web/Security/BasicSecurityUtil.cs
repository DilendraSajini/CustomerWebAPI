using CustomerWebAPI.Adapters.Persistence.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace CustomerWebAPI.Adapters.Web.Security
{
    public static class BasicSecurityUtil
    {
        private static IConfiguration configuration;

        public static void Initialize(IConfiguration configurationService)
        {
            configuration = configurationService;
        }
        public static Boolean IsValidBasicCredentials(LoginDTO loginDTO)
        {
            if (string.IsNullOrEmpty(loginDTO.UserName) ||
                               string.IsNullOrEmpty(loginDTO.Password))
            {
                return false;
            }
            else if (loginDTO.UserName.Equals(configuration.GetValue<string>("User:UserName")) &&
            loginDTO.Password.Equals(configuration.GetValue<string>("User:Password")))
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
            var secretKey = configuration.GetValue<string>("Jwt:Key");
            var symmetricKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(secretKey));
            var signinCredentials = new SigningCredentials
            (symmetricKey, SecurityAlgorithms.HmacSha256);

            return new JwtSecurityToken(
                            issuer: configuration.GetValue<string>("Jwt:Issuer"),
                            audience: configuration.GetValue<string>("Jwt:Audience"),
                            claims: new List<Claim>(),
                            expires: DateTime.Now.AddMinutes(10),
                            signingCredentials: signinCredentials
                        );
        }

        public static TokenValidationParameters GetTokenValidationParameters()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(Base64Decode(configuration.GetValue<string>("Jwt:Key")));
            RsaSecurityKey signingKey = new RsaSecurityKey(rsa);

            return new TokenValidationParameters
            {
                ValidIssuer = configuration.GetValue<string>("Jwt:Issuer"),
                ValidAudience = configuration.GetValue<string>("Jwt:Audience"),
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
