using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using GlobalX.ChatBots.WebexTeams.Configuration;
using Microsoft.Extensions.Options;

namespace GlobalX.ChatBots.WebexTeams.Services
{
    internal class HttpClientProxy : IHttpClientProxy
    {
        private readonly HttpClient _httpClient;
        private readonly IOptions<WebexTeamsSettings> _settings;

        public HttpClientProxy(HttpClient httpClient, IOptions<WebexTeamsSettings> settings)
        {
            _httpClient = httpClient;
            _settings = settings;

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _settings.Value.BotAuthToken);
        }

        public async Task<string> GetAsync(string path, string body = null)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{_settings.Value.WebexTeamsApiUrl}{path}"),
                Content = body != null ? new StringContent(body, Encoding.UTF8, "application/json") : null
            };
            var response = await _httpClient.SendAsync(request).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return responseBody;
        }

        public async Task<string> PostAsync(string path, string body = null)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_settings.Value.WebexTeamsApiUrl}{path}"),
                Content = body != null ? new StringContent(body, Encoding.UTF8, "application/json") : null
            };
            var response = await _httpClient.SendAsync(request).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return responseBody;
        }

        public async Task DeleteAsync(string path)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri($"{_settings.Value.WebexTeamsApiUrl}{path}")
            };

            var response = await _httpClient.SendAsync(request).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}
