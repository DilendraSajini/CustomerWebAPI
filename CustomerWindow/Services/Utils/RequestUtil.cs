using System.Net.Http.Headers;

namespace RestaurantFrontEnd.Services.Utils
{
    public static class RequestUtil
    {
        private static HttpClient client = new HttpClient();
        private static string jwtToken = "";

        public static HttpResponseMessage ExecuteGetRequest(string uri)
        {
            setRequestHeader();
            return client.GetAsync(uri).Result;
        }

        public static HttpResponseMessage ExecutePostRequest(string uri, HttpContent payload)
        {
            setRequestHeader();
            return client.PostAsync(uri, payload).Result;
        }

        public static async Task<HttpResponseMessage> ExecuteDeleteRequestAsync(string uri)
        {
            setRequestHeader();
            return await client.DeleteAsync(uri);
        }

        public static HttpResponseMessage ExecutePutRequest(string uri, HttpContent payload)
        {
            setRequestHeader();
            return client.PutAsync(uri, payload).Result;
        }

        public static void SaveJwtToken(string token)
        {
            jwtToken = token;
        }

        private static void setRequestHeader()
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken);
        }
    }
}
