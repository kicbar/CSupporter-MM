using CSupporter.Modules.Contractors.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CSupporter.Modules.Contractors.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class RequestSenderController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<RequestSenderController> _logger;

        public RequestSenderController(HttpClient httpClient, ILogger<RequestSenderController> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult<string>> GetSender()
        {
            _logger.LogInformation("Rozpoczecie wywolywania metody z API.");

            ContractorDto contractorDto = new ContractorDto 
            { 
                FirstName = "Bartlomiej",
                LastName = "Testowy"
            };

            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(
                "contractors-module/Contractors", contractorDto);
            response.EnsureSuccessStatusCode();

            return "Zawartosc odpowiedzi " + response.Content.ToString();
        }

    }
}
