using CustomerWebAPI.Adapters.Persistence.Mappers;
using CustomerWebAPI.Adapters.Persistence.Models;
using CustomerWebAPI.Config;
using System.Data.SqlClient;

namespace CustomerWebAPI.Adapters.Persistence.Services
{
    public class CustomerRepository: ICustomerRepository
    {
        public readonly string connectionString = ConfigProvider.GetConnectionString("ConnectionString");
        public List<Customer> GetAllCustomers()
        {
            string query = "SELECT TOP (10) * FROM [CustomersNew$]";
            List<Customer> newCustomerList = new List<Customer>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            newCustomerList.Add(CustomerMapper.GetCustomerFromSqlDataReader(reader));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }
                    reader.Close();
                    Console.WriteLine("Connected to SQL Server Express using Windows authentication.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error connecting to SQL Server Express: {ex.Message}");
                }

            }
            return newCustomerList;
        }

        public Customer GetCustomerById(int id)
        {
            string query = "SELECT * FROM [CustomersNew$] WHERE ID=@Id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            return CustomerMapper.GetCustomerFromSqlDataReader(reader);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }
                    reader.Close();
                    Console.WriteLine("Connected to SQL Server Express using Windows authentication.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error connecting to SQL Server Express: {ex.Message}");
                }

            }
            return new Customer();
        }

        public int CreateCustomer(Customer customer)
        {
            string query = "INSERT INTO [CustomersNew$] " +
            "(NAME_, SURNAME, NAMESURNAME, GENDER, " +
            "BIRTHDATE, EMAIL, TCNUMBER, TELNR, CITY, TOWN, " +
            "DISTRICT, STREET, POSTALCODE, ADDRESSTEXT) VALUES " +
            "(@firstName, @surName,  @fullName, @gender, " +
            "@birthDate, @email, @transactionNumber, @phoneNumber, " +
            "@city, @town, @district, @street, @postalCode, @address); SELECT SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    CustomerMapper.GetSqlCommandFromCustomer(command, customer);
                    connection.Open();
                    int customerId = Convert.ToInt32(command.ExecuteScalar());
                    if (customerId > 0)
                    {
                        Console.WriteLine("Customer created successfully.");
                        return customerId;
                    }
                    else
                    {
                        Console.WriteLine("Failed to create customer.");
                    }
                    Console.WriteLine("Connected to SQL Server Express using Windows authentication.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error connecting to SQL Server Express: {ex.Message}");
                }

            }
            return -1;
        }

        public int DeleteCustomerById(int customerId)
        {
            string query = "DELETE FROM [CustomersNew$] WHERE ID=@Id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", customerId);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected >0)
                    {
                        return customerId;
                    }
                    else
                    {
                        Console.WriteLine("No customer found.");
                    }
                    Console.WriteLine("Connected to SQL Server Express using Windows authentication.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error connecting to SQL Server Express: {ex.Message}");
                }

            }
            return -1;
        }
    }
}
