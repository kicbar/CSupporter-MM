using CSupporter.Modules.View.Models;
using CSupporter.Modules.View.Services.IServices;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSupporter.Modules.View.Services
{
    public class ContractorService : BaseService, IContractorService
    {
        private readonly IHttpClientFactory _clientFactory;

        public ContractorService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> GetAllContractorsAsync<T>()
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = ApiData.ApiType.GET,
                Url = ApiData.ApiAddress
            });
        }
    }
}
