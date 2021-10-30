using CSupporter.Modules.Contractors.DTO;
using CSupporter.Modules.View.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSupporter.Modules.View.Controllers
{
    public class ContractorsController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<ContractorsController> _logger;

        public ContractorsController(HttpClient httpClient, ILogger<ContractorsController> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<IActionResult> ContractorIndex()
        {
            List<ContractorDto> contractorList = new List<ContractorDto>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44324/contractors-module/Contractors"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _logger.LogInformation($"zwrocona odpowiedz {apiResponse}");
                    contractorList = JsonConvert.DeserializeObject<List<ContractorDto>>(apiResponse);
                }
            }
            return View(contractorList);
        }
    }
}
