using CustomerWebAPI.Adapters.Persistence.Models;
using CustomerWebAPI.Application.Services.Customer;
using log4net;

namespace CustomerWebAPI.Adapters.Web.Controllers.Customer
{
    public static class CustomerController
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(CustomerController));
        public static void MapCustomersEndpoints(this IEndpointRouteBuilder routes, IApplicationBuilder app)
        {
            ICustomerService customerService = app.ApplicationServices.GetService<ICustomerService>();

            var group = routes.MapGroup("/api/restaurent/v1.0/customers").WithTags(nameof(Customer));

            group.MapGet("/", () =>
            {
                return customerService.GetAllCustomers();
            })
            .WithName("GetAllCustomers")
            .WithOpenApi()
            .RequireAuthorization();

            group.MapGet("/async", () =>
            {
                return customerService.GetAllCustomersAsync();
            })
            .WithName("GetAllCustomersAsync")
            .WithOpenApi()
            .RequireAuthorization();

            group.MapGet("/{id}", (int id) =>
            {
                return customerService.GetCustomerById(id);
            })
            .WithName("GetCustomerById")
            .WithOpenApi()
            .RequireAuthorization();

            group.MapPut("/{id}", (int id, CustomerDTO input) =>
            {
                return TypedResults.NoContent();
            })
            .WithName("UpdateCustomer")
            .WithOpenApi()
            .RequireAuthorization();

            group.MapPost("/", (CustomerDTO customer) =>
            {
                return customerService.CreateCustomer(customer);
            })
            .WithName("CreateCustomer")
            .WithOpenApi()
            .RequireAuthorization();

            group.MapDelete("/{id}", (int id) =>
            {
                return customerService.DeleteCustomerById(id);
            })
            .WithName("DeleteCustomer")
            .WithOpenApi()
            .RequireAuthorization();
        }
    }
}