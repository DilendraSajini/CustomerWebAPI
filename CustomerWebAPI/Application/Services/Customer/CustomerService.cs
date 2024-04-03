using CustomerWebAPI.Adapters.Persistence.Models;
using CustomerWebAPI.Adapters.Persistence.Repository.Customer;
using log4net;

namespace CustomerWebAPI.Application.Services.Customer
{
    public class CustomerService : ICustomerService
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(CustomerService));
        private readonly ICustomerRepository customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public int CreateCustomer(CustomerDTO customer)
        {
            return customerRepository.CreateCustomer(customer);
        }

        public int DeleteCustomerById(int customerId)
        {
            return customerRepository.DeleteCustomerById(customerId);
        }

        public List<CustomerDTO> GetAllCustomers()
        {
            return customerRepository.GetAllCustomers();
        }
        public Task<List<CustomerDTO>> GetAllCustomersAsync()
        {
            return customerRepository.GetAllCustomersAsync();
        }

        public CustomerDTO GetCustomerById(int id)
        {
            return customerRepository.GetCustomerById(id);
        }
    }
}
