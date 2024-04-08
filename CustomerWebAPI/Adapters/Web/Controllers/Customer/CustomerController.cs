using CustomerWebAPI.Adapters.Persistence.Models;
using CustomerWebAPI.Application.Services.Customer;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantsBackEnd.Adapters.Web.Controllers.Customer
{
    [Route("/api/restaurant/v1.0/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet]
        public IEnumerable<CustomerDTO> Get()
        {
            return customerService.GetAllCustomers();
        }

        [HttpGet("async")]
        public Task<List<CustomerDTO>> GetAsync()
        {
            return customerService.GetAllCustomersAsync();
        }

        [HttpGet("{id}")]
        public CustomerDTO Get(int id)
        {
            return customerService.GetCustomerById(id);
        }

        [HttpPost]
        public int Post([FromBody] CustomerDTO customer)
        {
            return customerService.CreateCustomer(customer);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            customerService.DeleteCustomerById(id);
        }

        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return customerService.DeleteCustomerById(id);
        }
    }
}
