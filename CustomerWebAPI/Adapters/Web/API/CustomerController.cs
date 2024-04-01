using CustomerWebAPI.Adapters.Persistence.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CustomerWebAPI.Adapters.Web.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private List<Customer> customerList = Enumerable.Range(1, 5).Select(index =>
        {
            var customer = new Customer();
            customer.Id = index;
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
        }).ToList();

        [HttpGet, Authorize]
        public IEnumerable<Customer> Get()
        {
            return customerList;
        }

        [HttpGet("{id}")]
        public IEnumerable<Customer> Get(int id)
        {
            return customerList.Where(x => x.Id == id);
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
