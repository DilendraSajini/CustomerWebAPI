namespace CustomerWebAPI.Adapters.Web.Exceptions
{
    public class NoCustomerFoundException : Exception
    {
        public NoCustomerFoundException(): base("The requested customer was not found.") { }
        public NoCustomerFoundException(string message) : base(message) { }
    }
}
