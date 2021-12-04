using CSupporter.Modules.Factures.Domain.Interfaces;
using CSupporter.Shared.Infrastructure.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CSupporter.Modules.Factures.Application.Services
{
    public class BaseService : IBaseService
    {
        public IHttpClientFactory httpClient;

        public BaseService(IHttpClientFactory httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<string> SendAsync<T>(APIRequest apiRequest)
        {
            try
            {
                var client = httpClient.CreateClient("CSupprterAPI");
                HttpRequestMessage message = new();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(apiRequest.Url);
                client.DefaultRequestHeaders.Clear();

                if (apiRequest.Data != null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(apiRequest.Data), Encoding.UTF8, "application/json");
                }
                HttpResponseMessage apiResponse = null;

                switch (apiRequest.ApiType)
                {
                    case StaticDetails.ApiType.POST:
                        message.Method = HttpMethod.Post;
                        break;
                    case StaticDetails.ApiType.PUT:
                        message.Method = HttpMethod.Put;
                        break;
                    case StaticDetails.ApiType.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;
                    case StaticDetails.ApiType.GET:
                        break;
                    default:
                        message.Method = HttpMethod.Get;
                        break;
                }

                apiResponse = await client.SendAsync(message);
                var apiContent = await apiResponse.Content.ReadAsStringAsync();
                return apiContent;
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

        public void Dispose() => GC.SuppressFinalize(true);
    }
}
