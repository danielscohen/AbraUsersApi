namespace AbraUserApi
{
    public class HttpRequest
    {
        private static HttpClient sharedClient = new()
        {
            BaseAddress = new Uri("https://randomuser.me/api/"),
        };

        static async Task<HttpResponseMessage> GetUserDataAsync(HttpClient httpClient, string gender)
        {
            using HttpResponseMessage response = await httpClient.GetAsync($"?results=10&gender={gender}");

            return response;

        }
    }
}
