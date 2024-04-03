namespace CustomerWebAPI.Adapters.Web.Exceptions
{
    public class NoCustomerCreateException : Exception
    {
        public NoCustomerCreateException(): base("The requested customer was not created.") { }
        public NoCustomerCreateException(string message) : base(message) { }
    }
}
