using CSupporter.Shared.Abstractions.IMessages.IServices;
using CSupporter.Shared.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CSupporter.Shared.Infrastructure.Messages.Services
{
    public class ContractorAPIService : RequestSender, IContractorAPIService
    {
        private readonly IHttpClientFactory _clientFactory;

        public ContractorAPIService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> GetContractorByIdAsync<T>(string contractorId)
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = StaticDetails.CSupporterAPI + "api/contractor/" + contractorId
            });
        }

        public async Task<T> GetAllContractors<T>()
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = StaticDetails.CSupporterAPI + "api/contractor"
            });
        }
    }
}
