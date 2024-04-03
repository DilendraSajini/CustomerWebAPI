namespace CustomerWebAPI.Adapters.Web.Exceptions
{
    public class DBConnectionException: Exception
    {
        public DBConnectionException(): base("Error connecting to database") { }
        public DBConnectionException(string message) : base(message) { }
    }
}
