using CustomerWebAPI.Adapters.Persistence.Models;
using log4net;
using System.Data;
using System.Data.SqlClient;

namespace CustomerWebAPI.Adapters.Persistence.Mappers
{
    public static class CustomerMapper
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(CustomerMapper));
        public static CustomerDTO GetCustomerFromSqlDataReader(SqlDataReader reader)
        {
            var customer = new CustomerDTO();
            customer.Id = reader.GetInt32(reader.GetOrdinal("ID"));
            customer.FirstName = reader.GetString(reader.GetOrdinal("NAME_"));
            customer.SurName = reader.GetString(reader.GetOrdinal("SURNAME"));
            customer.FullName = reader.GetString(reader.GetOrdinal("NAMESURNAME"));
            customer.Gender = reader.GetString(reader.GetOrdinal("GENDER"));
            customer.BirthDate = reader.GetString(reader.GetOrdinal("BIRTHDATE"));
            customer.Email = reader.GetString(reader.GetOrdinal("EMAIL"));
            customer.TransactionNumber = reader.GetString(reader.GetOrdinal("TCNUMBER"));
            customer.PhoneNumber = reader.GetString(reader.GetOrdinal("TELNR"));
            customer.City = reader.GetString(reader.GetOrdinal("CITY"));
            customer.Town = reader.GetString(reader.GetOrdinal("TOWN"));
            customer.District = reader.GetString(reader.GetOrdinal("DISTRICT"));
            customer.Street = reader.GetString(reader.GetOrdinal("STREET"));
            customer.PostalCode = reader.GetString(reader.GetOrdinal("POSTALCODE"));
            customer.Address = reader.GetString(reader.GetOrdinal("ADDRESSTEXT"));
            return customer;
        }

        public static SqlCommand GetSqlCommandFromCustomer(SqlCommand command, CustomerDTO customer)
        {
            command.Parameters.AddWithValue("@firstName", customer.FirstName);
            command.Parameters.AddWithValue("@surName", customer.SurName);
            command.Parameters.AddWithValue("@fullName", customer.FullName);
            command.Parameters.AddWithValue("@gender", customer.Gender);
            command.Parameters.AddWithValue("@birthDate", customer.BirthDate);
            command.Parameters.AddWithValue("@email", customer.Email);
            command.Parameters.AddWithValue("@transactionNumber", customer.TransactionNumber);
            command.Parameters.AddWithValue("@phoneNumber", customer.PhoneNumber);
            command.Parameters.AddWithValue("@city", customer.City);
            command.Parameters.AddWithValue("@town", customer.Town);
            command.Parameters.AddWithValue("@district", customer.District);
            command.Parameters.AddWithValue("@street", customer.Street);
            command.Parameters.AddWithValue("@postalCode", customer.PostalCode);
            command.Parameters.AddWithValue("@address", customer.Address);

            return command;
        }

    }
}
