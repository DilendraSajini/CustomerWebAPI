using CustomerWebAPI.Adapters.Persistence.Models;

namespace CustomerWebAPI.Adapters.Persistence.Repository.Customer
{
    public interface ICustomerRepository
    {
        List<CustomerDTO> GetAllCustomers();
        Task<List<CustomerDTO>> GetAllCustomersAsync();
        CustomerDTO GetCustomerById(int id);
        int CreateCustomer(CustomerDTO customer);
        int DeleteCustomerById(int customerId);

    }
}
