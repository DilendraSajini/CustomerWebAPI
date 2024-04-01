using CustomerWebAPI.Config;
using System.Data.SqlClient;

namespace CustomerWebAPI.Adapters.Persistence
{
    public class DataService
    {
        protected string connectionString = "";

        protected DataService()
        {
            connectionString = ConfigProvider.GetConnectionString("ConnectionString");
        }
    }
}
