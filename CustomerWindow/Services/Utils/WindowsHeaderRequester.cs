using System.Net;

namespace RestaurantFrontEnd.Services.Utils
{
    public class WindowsHeaderRequester
    {
        private HttpClient client; 

        public WindowsHeaderRequester()
        {
            client = new HttpClient(new HttpClientHandler { Credentials = CredentialCache.DefaultNetworkCredentials });
        }
        public HttpResponseMessage ExecuteGetRequest(string uri)
        {
            return client.GetAsync(uri).Result;
        }

    }
}
