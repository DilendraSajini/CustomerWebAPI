var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.MapGet("/customers", () =>
//{

//    var customerList = Enumerable.Range(1, 5).Select(index =>
//    {
//        var customer = new Customer();
//        //customer.Id = index;
//        customer.FirstName = "Jared";
//        customer.LastName = "Jarvis";
//        customer.CompanyName = "Sanchez-Fletcher";
//        customer.City = "Hatfieldshire";
//        customer.Country = "Eritrea";
//        customer.Zip = "0094";
//        customer.PhoneNumber1 = "274.188.8773x41185";
//        customer.PhoneNumber2 = "001-215-760-4642x969";
//        customer.Email = "gabriellehartman@benjamin.com";
//        customer.Website = "https://www.mccarthy.info/";

//        return customer;
//    }).ToArray();
//    return customerList;
//})
//.WithName("GetCustomerDetails")
//.WithOpenApi();
app.UseAuthorization();

app.MapControllers();
app.Run();

