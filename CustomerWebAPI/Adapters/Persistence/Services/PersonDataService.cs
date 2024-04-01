using System.Data.SqlClient;

namespace CustomerWebAPI.Adapters.Persistence.Services
{
    public class PersonDataService : DataService
    {
        private PersonDataService() : base() { }

        public List<Models.Customer> GetPeople()
        {
            string query = "SELECT * FROM [us-500]";
            return queryData(query);
        }
        private List<Models.Customer> queryData(string query)
        {
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
                            string id = reader.GetString(0);
                            reader.GetValue(reader.GetOrdinal("first_name"));
                            string name = reader.GetString(1);
                            Console.WriteLine($"ID: {id}, Name: {name}");
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
            return new List<Models.Customer>();
        }

    }
}
