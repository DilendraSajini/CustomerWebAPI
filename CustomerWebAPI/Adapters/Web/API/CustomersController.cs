using CustomerWebAPI.Adapters.Persistence.Models;
using CustomerWebAPI.Config;

namespace CustomerWebAPI.Adapters.Web.Controllers
{
public static class CustomerEndpoints
{
        private static List<Customer> customerList = Enumerable.Range(1, 5).Select(index =>
    {
        var customer = new Customer();
        customer.Id = index;
        customer.FirstName = "Jared";
        customer.LastName = "Jarvis";
        customer.CompanyName = "Sanchez-Fletcher";
        customer.City = "Hatfieldshire";
        customer.Country = "Eritrea";
        customer.Zip = "0094";
        customer.PhoneNumber1 = "274.188.8773x41185";
        customer.PhoneNumber2 = "001-215-760-4642x969";
        customer.Email = "gabriellehartman@benjamin.com";
        customer.Website = "https://www.mccarthy.info/";

        return customer;
    }).ToList();

    public static void MapCustomersEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/customers").WithTags(nameof(Customer));

            group.MapGet("/", () =>
            {
                return customerList;
            })
            .WithName("GetAllCustomers")
            .WithOpenApi()
            .RequireAuthorization();

        group.MapGet("/{id}", (int id) =>
        {
            return customerList.Where(x => x.Id == id);
        })
        .WithName("GetCustomerById")
        .WithOpenApi();

        group.MapPut("/{id}", (int id, Customer input) =>
        {
            return TypedResults.NoContent();
        })
        .WithName("UpdateCustomer")
        .WithOpenApi();

        group.MapPost("/", (Customer model) =>
        {
            
        })
        .WithName("CreateCustomer")
        .WithOpenApi();

        group.MapDelete("/{id}", (int id) =>
        {
          
        })
        .WithName("DeleteCustomer")
        .WithOpenApi();
    }
}}