﻿using log4net;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using RestaurantFrontEnd.Services.Models;
using RestaurantFrontEnd.Services.Utils;
using System.Configuration;
using System.Text;

namespace RestaurantFrontEnd.Services.Services
{
    internal class SigninService
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(SigninService));
        private string signinServicePath = ConfigurationManager.AppSettings["baseUrl"] + "login/";
        public void Login(Login login)
        {
            string jsonPayload = JsonConvert.SerializeObject(login);
            HttpContent payload = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            var response = RequestUtil.ExecutePostRequest(signinServicePath, payload);
            if (response != null && response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                string jwtToken = data.Trim('"');
                RequestUtil.SaveJwtToken(jwtToken);
            }
            else
            {
                log.Error($"Error login to the system");
                throw new UnauthorizedAccessException();
            }
        }
    }
}