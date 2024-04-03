using CustomerWebAPI.Adapters.Persistence.Models;

namespace CustomerWebAPI.Adapters.Web.Services
{
    public interface ICustomerService
    {
        public List<Customer> GetAllCustomers();
        public Task<List<Customer>> GetAllCustomersAsync();
        public Customer GetCustomerById(int id);
        public int CreateCustomer(Customer customer);
        public int DeleteCustomerById(int customerId);
    }
}