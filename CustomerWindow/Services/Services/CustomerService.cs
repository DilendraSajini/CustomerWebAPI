using RestaurantFrontEnd.Services.Models;
using RestaurantFrontEnd.Services.Utils;
using System.Configuration;

namespace RestaurantFrontEnd.Services.Services
{
    internal class CustomerService
    {
        private string customerServicePath = ConfigurationManager.AppSettings["baseUrl"] + "customers/";

        public List<Customer> getCustomers()
        {
            List<Customer> customers = new List<Customer>();
            var response = RequestUtil.ExecuteGetRequest($"{customerServicePath}");
            if (response != null && response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                Newtonsoft.Json.JsonConvert.PopulateObject(data.ToString(), customers);
            }
            return customers;
        }
    }
}
