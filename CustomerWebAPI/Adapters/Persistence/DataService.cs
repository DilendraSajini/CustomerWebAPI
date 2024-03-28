using CustomerWebAPI.Config;
using System.Data.SqlClient;

namespace CustomerWebAPI.Adapters.Persistence
{
    public class DataService
    {
        protected string connectionString = "";
        protected ConfigProvider configProvider;

        protected DataService()
        {
            configProvider = new ConfigProvider();
            connectionString = configProvider.GetConnectionString("ConnectionString");
        }
    }
}
