using CustomerWebAPI.Adapters.Persistence.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CustomerWebAPI.Adapters.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ILogger<CustomersController> _logger;

        public CustomersController(ILogger<CustomersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            var customerList = Enumerable.Range(1, 5).Select(index =>
            {
                var customer = new Customer();
                //customer.Id = index;
                customer.FirstName = "Jared";
                customer.LastName = "Jarvis";
                customer.CompanyName = "Sanchez-Fletcher";
                customer.City = "Hatfieldshire";
                customer.Country = "Eritrea";
                customer.Zip = "0094";
                customer.PhoneNumber1 = "274.188.8773x41185";
                customer.PhoneNumber2 = "001-215-760-4642x969";
                customer.Email = "gabriellehartman@benjamin.com";
                customer.Website = "https://www.mccarthy.info/";

                return customer;
            }).ToArray();
            return customerList;
        }
    }
}