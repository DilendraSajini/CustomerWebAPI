using CustomerWebAPI.Adapters.Persistence.Models;
using CustomerWebAPI.Adapters.Persistence.Services;
using log4net;

namespace CustomerWebAPI.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(CustomerService));
        private readonly ICustomerRepository customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
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
        public Task<List<Customer>> GetAllCustomersAsync()
        {
            return customerRepository.GetAllCustomersAsync();
        }

        public Customer GetCustomerById(int id)
        {
            return customerRepository.GetCustomerById(id);
        }
    }
}
