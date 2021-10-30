using CSupporter.Modules.Contractors.DTO;
using CSupporter.Modules.View.Services.IServices;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
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

        public async Task<List<ContractorDto>> SendGetRequest()
        {
            List<ContractorDto> contractorList = new List<ContractorDto>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44324/contractors-module/Contractors"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _logger.LogInformation($"[RRS] reutrned response {apiResponse}");
                    contractorList = JsonConvert.DeserializeObject<List<ContractorDto>>(apiResponse);
                    _logger.LogInformation($"[RRS] transfered response {apiResponse}");
                }
            }
            return contractorList;
        }
    }
}
