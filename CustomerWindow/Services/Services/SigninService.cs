using log4net;
using Newtonsoft.Json;
using RestaurantFrontEnd.Services.Models;
using RestaurantFrontEnd.Services.Utils;
using System.Configuration;
using System.Text;

namespace RestaurantFrontEnd.Services.Services
{
    internal class SigninService: ISigninService
    {
        private readonly ILog log = LogManager.GetLogger(typeof(SigninService));
        private readonly JWTHeaderRequester jwtHeaderRequester;
        private readonly WindowsHeaderRequester windowsHeaderRequester;
        private string signinServicePath = ConfigurationManager.AppSettings["baseUrl"] + "login/";
        
        public SigninService()
        {
            jwtHeaderRequester = new JWTHeaderRequester();
            windowsHeaderRequester = new WindowsHeaderRequester();
        }
        public void LoginWithBasicCredentials(Login login)
        {
            string jsonPayload = JsonConvert.SerializeObject(login);
            HttpContent payload = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            var response = jwtHeaderRequester.ExecutePostRequest(signinServicePath, payload);
            if (response != null && response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                string jwtToken = data.Trim('"');
                jwtHeaderRequester.SaveJwtToken(jwtToken);
            }
            else
            {
                log.Error($"Error login to the system");
                throw new UnauthorizedAccessException();
            }
        }

        public void LoginWithWindowsCredentials()
        {
            var response = windowsHeaderRequester.ExecuteGetRequest(ConfigurationManager.AppSettings["STSUrl"] + "?appName=username");
            if (response != null && response.IsSuccessStatusCode)
            {
                var jwtToken = response.Content.ReadAsStringAsync().Result;
                jwtHeaderRequester.SaveJwtToken(jwtToken); 
            }
            else
            {
                log.Error($"Error login to the system");
                throw new UnauthorizedAccessException();
            }
        }
    }
}