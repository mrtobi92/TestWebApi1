using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DotnetWebApiUnitTesting.Services
{
    public class ApiService : IAPIService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://example.com");
        }

        /// <summary>
        /// CheckPartnerIdAsync
        /// </summary>
        /// <param name="partnerId"></param>
        /// <returns></returns>
        public async Task<string> CheckPartnerIdAsync(string partnerId)
        {
            var result = "";

            // Set a short timeout to simulate the exception
            _httpClient.Timeout = TimeSpan.FromMilliseconds(10);

            try
            {
                var result = await _httpClient.GetFromJsonAsync<UserDto>($"api/PartnerVerification/{partnerId}");

                return result;
            }
            catch (TimeoutException ex)
            {

                return result = $"Timed out: {ex.Message}";
            }
            catch (HttpRequestException ex)
            {

                return result = $"HttpRequestException: {ex.Message}";
            }
        }

    }
}
