using CSupporter.Modules.Contractors.DTO;
using CSupporter.Modules.View.Models;
using CSupporter.Modules.View.Services.IServices;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CSupporter.Modules.View.Services
{
    public class RequestSenderService : IRequestSenderService
    {
        private readonly ILogger<RequestSenderService> _logger;

        public RequestSenderService(ILogger<RequestSenderService> logger)
        {
            _logger = logger;
        }

        public async Task<List<ContractorDto>> SendGetAllRequest()
        {
            List<ContractorDto> contractorList = new List<ContractorDto>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(ApiData.ApiAddress + "/contractors-module/Contractors"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    contractorList = JsonConvert.DeserializeObject<List<ContractorDto>>(apiResponse);
                    _logger.LogInformation($"[RRS] - [SendGetAllRequest] transfered response {apiResponse}");
                }
            }
            return contractorList;
        }

        public async Task<ContractorDto> SendGetRequest()
        {
            ContractorDto contractor = new ContractorDto();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(ApiData.ApiAddress + "/contractors-module/Contractors"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    contractor = JsonConvert.DeserializeObject<ContractorDto>(apiResponse);
                    _logger.LogInformation($"[RRS] - [SendGetRequest] transfered response {apiResponse}");
                }
            }
            return contractor;
        }

        public async Task<ContractorDto> SendPostRequest(ContractorDto contractorDto)
        {
            ContractorDto contractor = new ContractorDto();
            var content = new StringContent(JsonConvert.SerializeObject(contractorDto), Encoding.UTF8, "application/json");
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PostAsync(ApiData.ApiAddress + "/contractors-module/Contractors", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _logger.LogInformation($"[RRS] - [SendGetRequest] transfered response {apiResponse}");
                    contractor = JsonConvert.DeserializeObject<ContractorDto>(apiResponse);
                    _logger.LogInformation($"[RRS] - [SendGetRequest] transfered response {contractor}");
                }
            }
            return contractor;
        }
    }
}
