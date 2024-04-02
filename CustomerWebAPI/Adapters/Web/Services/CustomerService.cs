using CustomerWebAPI.Adapters.Persistence.Models;
using CustomerWebAPI.Adapters.Persistence.Services;

namespace CustomerWebAPI.Adapters.Web.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;
        public CustomerService(ICustomerRepository customerRepository) {
            this.customerRepository = customerRepository;
        }

        public int CreateCustomer(Customer customer)
        {
            return customerRepository.CreateCustomer(customer);
        }

        public int DeleteCustomerById(int customerId)
        {
            return customerRepository.DeleteCustomerById(customerId);
        }

        public List<Customer> GetAllCustomers()
        {
            return customerRepository.GetAllCustomers();
        }

        public Customer GetCustomerById(int id)
        {
            return customerRepository.GetCustomerById(id);
        }
    }
}
