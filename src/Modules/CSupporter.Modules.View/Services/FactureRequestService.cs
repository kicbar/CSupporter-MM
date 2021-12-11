using CSupporter.Modules.View.Models;
using CSupporter.Modules.View.Services.IServices;
using System.Net.Http;
using System.Threading.Tasks;
using static CSupporter.Modules.View.Models.ApiData;

namespace CSupporter.Modules.View.Services
{
    public class FactureRequestService : BaseService, IFactureRequestService
    {
        private readonly IHttpClientFactory _clientFactory;

        public FactureRequestService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> GetAllFactures<T>()
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = ApiType.GET,
                Url = ApiAddress + "api/facture"
            });
        }

        public async Task<T> GetFactureById<T>(int factureId)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = ApiType.GET,
                Url = ApiAddress + "api/facture/" + factureId
            });
        }
    }
}
