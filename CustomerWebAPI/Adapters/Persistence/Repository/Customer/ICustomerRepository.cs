using CustomerWebAPI.Adapters.Persistence.Models;

namespace CustomerWebAPI.Adapters.Persistence.Repository.Customer
{
    public interface ICustomerRepository
    {
        public List<CustomerDTO> GetAllCustomers();
        public Task<List<CustomerDTO>> GetAllCustomersAsync();
        public CustomerDTO GetCustomerById(int id);
        public int CreateCustomer(CustomerDTO customer);
        public int DeleteCustomerById(int customerId);

    }
}
