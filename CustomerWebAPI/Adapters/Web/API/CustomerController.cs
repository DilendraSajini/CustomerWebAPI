using CustomerWebAPI.Adapters.Persistence.Models;
using CustomerWebAPI.Adapters.Persistence.Services;

namespace CustomerWebAPI.Adapters.Web.Controllers
{
public static class CustomerController
{
    public static void MapCustomersEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/customers").WithTags(nameof(Customer));

            group.MapGet("/", () =>
            {
                return CustomerDataService.GetCustomers();
            })
            .WithName("GetAllCustomers")
            .WithOpenApi()
            .RequireAuthorization();

        group.MapGet("/{id}", (int id) =>
        {
            return CustomerDataService.GetCustomerById(id);
        })
        .WithName("GetCustomerById")
        .WithOpenApi();

        group.MapPut("/{id}", (int id, Customer input) =>
        {
            return TypedResults.NoContent();
        })
        .WithName("UpdateCustomer")
        .WithOpenApi();

        group.MapPost("/", (Customer customer) =>
        {
            return CustomerDataService.CreateCustomer(customer);
        })
        .WithName("CreateCustomer")
        .WithOpenApi();

        group.MapDelete("/{id}", (int id) =>
        {
            return CustomerDataService.DeleteCustomerById(id);
        })
        .WithName("DeleteCustomer")
        .WithOpenApi();
    }
}}