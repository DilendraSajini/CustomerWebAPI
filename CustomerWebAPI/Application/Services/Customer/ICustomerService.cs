using CustomerWebAPI.Adapters.Persistence.Models;

namespace CustomerWebAPI.Application.Services.Customer
{
    public interface ICustomerService
    {
        public List<CustomerDTO> GetAllCustomers();
        public Task<List<CustomerDTO>> GetAllCustomersAsync();
        public CustomerDTO GetCustomerById(int id);
        public int CreateCustomer(CustomerDTO customer);
        public int DeleteCustomerById(int customerId);
    }
}