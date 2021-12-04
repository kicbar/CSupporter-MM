using CSupporter.Modules.Factures.Domain.Interfaces;
using CSupporter.Shared.Infrastructure.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSupporter.Modules.Factures.Application.Services
{
    public class ContractorAPIService : BaseService, IContractorAPIService
    {
        private readonly IHttpClientFactory _clientFactory;

        public ContractorAPIService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<string> GetContractorByIdAsync<T>(int contractorId)
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = StaticDetails.CSupporterAPI + "/contractors-module/Contractors/" + contractorId
            });
        }
    }
}
