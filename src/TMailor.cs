using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;

namespace TMailorApi
{
    public class TMailor
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://tmailor.com/api";
        public TMailor()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation(
                "User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/141.0.0.0 Safari/537.36");
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        
        public async Task<string> GenerateEmail()
        {
            var data = JsonContent.Create(new
            {
                action = "newemail",
                curentToken = ""
            });
            var response = await httpClient.PostAsync(apiUrl, data);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetInbox(string accessToken)
        {
            var data = JsonContent.Create(new
            {
                action = "listinbox",
                accesstoken = accessToken
            });
            var response = await httpClient.PostAsync(apiUrl, data);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
