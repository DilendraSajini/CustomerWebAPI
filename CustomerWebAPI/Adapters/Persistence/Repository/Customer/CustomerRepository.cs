﻿using CustomerWebAPI.Adapters.Persistence.Mappers;
using CustomerWebAPI.Adapters.Persistence.Models;
using CustomerWebAPI.Adapters.Web.Exceptions;
using log4net;
using System.Data;
using System.Data.SqlClient;

namespace CustomerWebAPI.Adapters.Persistence.Repository.Customer
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly string connectionString;
        private readonly ILog log = LogManager.GetLogger(typeof(CustomerRepository));
        public CustomerRepository(IConfiguration configuration)
        {
            this.connectionString = configuration.GetValue<string>("ConnectionString");
        }

        public List<CustomerDTO> GetAllCustomers()
        {
            string query = "SELECT TOP (10) * FROM [CustomersNew$]";
            List<CustomerDTO> newCustomerList = new List<CustomerDTO>();
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
                        log.Debug("No customers found.");
                    }
                    reader.Close();
                    log.Debug("Connected to database successfully");
                }
                catch (SqlException ex)
                {
                    log.Error($"Error connecting to database: {ex.Message}");
                    throw new DBConnectionException();
                }

            }
            return newCustomerList.OrderBy(customer => customer.Id).ToList();
        }
        public async Task<List<CustomerDTO>> GetAllCustomersAsync()
        {
            string query = "SELECT TOP (10) * FROM [CustomersNew$]";
            List<CustomerDTO> newCustomerList = new List<CustomerDTO>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = await command.ExecuteReaderAsync();
                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            newCustomerList.Add(CustomerMapper.GetCustomerFromSqlDataReader(reader));
                        }
                    }
                    else
                    {
                        log.Debug("No customers found.");
                    }
                    reader.Close();
                    log.Debug("Connected to database successfully");
                }
                catch (SqlException ex)
                {
                    log.Error($"Error connecting to database: {ex.Message}");
                    throw new DBConnectionException();
                }

            }
            return newCustomerList.OrderBy(customer => customer.Id).ToList();
        }

        public CustomerDTO GetCustomerById(int id)
        {
            string query = "SELECT * FROM [CustomersNew$] WHERE ID=@Id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                return CustomerMapper.GetCustomerFromSqlDataReader(reader);
                            }
                        }
                        else
                        {
                            log.Debug("No customer found.");
                            throw new NoCustomerFoundException();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    log.Error($"Error connecting to SQL Server Express: {ex.Message}");
                    throw new DBConnectionException();
                }
            }
            return new CustomerDTO();
        }

        public int CreateCustomer(CustomerDTO customer)
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
                        log.Debug("Failed to create customer.");
                        throw new NoCustomerCreateException();
                    }
                }
                catch (SqlException ex)
                {
                    log.Error($"Error connecting to database: {ex.Message}");
                    throw new DBConnectionException();
                }

            }
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
                    if (rowsAffected > 0)
                    {
                        return customerId;
                    }
                    else
                    {
                        log.Debug("No customer found.");
                        throw new NoCustomerFoundException();
                    }
                }
                catch (SqlException ex)
                {
                    log.Error($"Error connecting to database: {ex.Message}");
                    throw new DBConnectionException();
                }
            }
        }
    }
}
