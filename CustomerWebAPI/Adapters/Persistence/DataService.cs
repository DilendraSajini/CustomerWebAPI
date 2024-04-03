using CustomerWebAPI.Config;
using System.Data.SqlClient;

namespace CustomerWebAPI.Adapters.Persistence
{
    public static class DataService
    {
        public static readonly string connectionString = ConfigProvider.GetConfiguration("ConnectionString");
    }
}
