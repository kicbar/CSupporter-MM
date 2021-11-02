using CSupporter.Modules.Contractors.DTO;
using CSupporter.Modules.View.Models;
using CSupporter.Modules.View.Services.IServices;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
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
                }
            }
            return contractorList;
        }

        public async Task<ContractorDto> SendGetRequest(Guid id)
        {
            ContractorDto contractor = new ContractorDto();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(ApiData.ApiAddress + "/contractors-module/Contractors/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    contractor = JsonConvert.DeserializeObject<ContractorDto>(apiResponse);
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
                    contractor = JsonConvert.DeserializeObject<ContractorDto>(apiResponse);
                }
            }
            return contractor;
        }

        public async Task<ContractorDto> SendUpdateRequest(ContractorDto contractorDto)
        {
            ContractorDto contractor = new ContractorDto();
            var content = new StringContent(JsonConvert.SerializeObject(contractorDto), Encoding.UTF8, "application/json");
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PutAsync(ApiData.ApiAddress + "/contractors-module/Contractors/" + contractorDto.Id, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    contractor = JsonConvert.DeserializeObject<ContractorDto>(apiResponse);
                }
            }
            return contractor;
        }

        public async Task<ContractorDto> SendDeleteRequest(Guid id)
        {
            ContractorDto contractor = new ContractorDto();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync(ApiData.ApiAddress + "/contractors-module/Contractors/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return contractor;
        }
    }
}
