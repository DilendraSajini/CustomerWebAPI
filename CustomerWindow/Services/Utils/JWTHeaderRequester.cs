using System.Net;
using System.Net.Http.Headers;

namespace RestaurantFrontEnd.Services.Utils
{
    public class JWTHeaderRequester
    {
        private HttpClient client;
        private string jwtToken;

        public JWTHeaderRequester()
        {
            client = new HttpClient();
            jwtToken = "";
        }
        public HttpResponseMessage ExecuteGetRequest(string uri)
        {
            setRequestHeader();
            return client.GetAsync(uri).Result;
        }

        public HttpResponseMessage ExecutePostRequest(string uri, HttpContent payload)
        {
            setRequestHeader();
            return client.PostAsync(uri, payload).Result;
        }

        public async Task<HttpResponseMessage> ExecuteDeleteRequestAsync(string uri)
        {
            setRequestHeader();
            return await client.DeleteAsync(uri);
        }

        public HttpResponseMessage ExecutePutRequest(string uri, HttpContent payload)
        {
            setRequestHeader();
            return client.PutAsync(uri, payload).Result;
        }
        public void SaveJwtToken(string token)
        {
            jwtToken = token;
        }

        private void setRequestHeader()
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken);
        }
    }
}
