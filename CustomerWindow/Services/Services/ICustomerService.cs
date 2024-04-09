using RestaurantFrontEnd.Services.Models;

namespace RestaurantFrontEnd.Services.Services
{
    internal interface ICustomerService
    {
        List<Customer> getCustomers();
    }
}
