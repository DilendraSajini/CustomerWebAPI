using CustomerWebAPI.Adapters.Persistence.Models;
using CustomerWebAPI.Adapters.Persistence.Services;
using CustomerWebAPI.Adapters.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace CustomerWebAPI.Adapters.Web.Controllers
{
    public static class CustomerController
    {
        public static void MapCustomersEndpoints(this IEndpointRouteBuilder routes, IApplicationBuilder app)
        {
            //ICustomerRepository customerRepo = app.ApplicationServices.GetRequiredService<CustomerWebAPI.Adapters.Web.Services>();
            ICustomerService customerService = app.ApplicationServices.GetService<ICustomerService>();

            var group = routes.MapGroup("/api/customers").WithTags(nameof(Customer));

            group.MapGet("/", () =>
            {
                return customerService.GetAllCustomers();
            })
            .WithName("GetAllCustomers")
            .WithOpenApi()
            .RequireAuthorization();

            group.MapGet("/{id}", (int id) =>
            {
                return customerService.GetCustomerById(id);
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
                return customerService.CreateCustomer(customer);
            })
            .WithName("CreateCustomer")
            .WithOpenApi();

            group.MapDelete("/{id}", (int id) =>
            {
                return customerService.DeleteCustomerById(id);
            })
            .WithName("DeleteCustomer")
            .WithOpenApi();
        }
    }
}