using CSupporter.Modules.View.Models;
using CSupporter.Modules.View.Services.IServices;
using System.Net.Http;
using System.Threading.Tasks;
using static CSupporter.Modules.View.Models.ApiData;

namespace CSupporter.Modules.View.Services
{
    public class ProductRequestService : BaseService, IProductRequestService
    {
        private readonly IHttpClientFactory _clientFactory;

        public ProductRequestService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> GetAllProducts<T>()
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = ApiType.GET,
                Url = ApiAddress + "api/product"
            });
        }

        public async Task<T> GetProductById<T>(int productId)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = ApiType.GET,
                Url = ApiAddress + "api/product/" + productId
            });
        }
    }
}
