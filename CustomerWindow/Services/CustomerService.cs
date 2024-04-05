using RestaurantFrontEnd.Services.Models;
using System.Configuration;

namespace RestaurantFrontEnd.Services
{
    internal class CustomerService
    {
        private string customerServicePath = ConfigurationManager.AppSettings["baseUrl"] + "customers/";
        private HttpClient client;

        internal CustomerService() {
            client = new HttpClient();
        }    

        public List<Customer> getCustomers()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer
            {
                FirstName = "firstName1",
                SurName = "surName1",
                FullName = "fullName1",
                Gender = "gender1",
                BirthDate = "birthDate1",
                Email = "email1",
                TransactionNumber = "transactionNumber1",
                PhoneNumber = "phoneNumber1",
                City = "city1",
                Town = "town1",
                District = "district1",
                Street = "street1",
                PostalCode = "postalCode1",
                Address = "address1"
            });
            //Customer customer = client.GetAsync($"{customerServicePath}").Result;
            return customers;
        }
    }
}
