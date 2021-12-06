using CSupporter.Shared.Abstractions.IMessages.IServices;
using CSupporter.Shared.Infrastructure.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSupporter.Shared.Infrastructure.Messages.Services
{
    public class ProductAPIService : RequestSender, IProductAPIService
    {
        private readonly IHttpClientFactory _clientFactory;

        public ProductAPIService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> GetAllProducts<T>()
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = StaticDetails.CSupporterAPI + "api/product"
            });
        }

        public async Task<T> GetProductByIdAsync<T>(int productId)
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = StaticDetails.CSupporterAPI + "api/product/" + productId
            });
        }
    }
}
