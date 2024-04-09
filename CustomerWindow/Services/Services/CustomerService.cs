using RestaurantFrontEnd.Services.Models;
using RestaurantFrontEnd.Services.Utils;
using System.Configuration;

namespace RestaurantFrontEnd.Services.Services
{
    internal class CustomerService : ICustomerService
    {
        private string customerServicePath;
        private readonly JWTHeaderRequester jwtHeaderRequester;

        public CustomerService()
        {
            customerServicePath = ConfigurationManager.AppSettings["baseUrl"] + "customers/";
            jwtHeaderRequester = new JWTHeaderRequester();
        }
        public List<Customer> getCustomers()
        {
            List<Customer> customers = new List<Customer>();
            var response = jwtHeaderRequester.ExecuteGetRequest($"{customerServicePath}");
            if (response != null && response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                Newtonsoft.Json.JsonConvert.PopulateObject(data.ToString(), customers);
            }
            return customers;
        }
    }
}
