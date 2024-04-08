using CustomerWebAPI.Adapters.Persistence.Models;

namespace CustomerWebAPI.Application.Services.Customer
{
    public interface ICustomerService
    {
        List<CustomerDTO> GetAllCustomers();
        Task<List<CustomerDTO>> GetAllCustomersAsync();
        CustomerDTO GetCustomerById(int id);
        int CreateCustomer(CustomerDTO customer);
        int DeleteCustomerById(int customerId);
    }
}