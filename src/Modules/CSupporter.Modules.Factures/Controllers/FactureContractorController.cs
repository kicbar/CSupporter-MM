using CSupporter.Modules.Factures.Domain.Interfaces;
using CSupporter.Shared.Abstractions.IMessages.IServices;
using CSupporter.Shared.Infrastructure.Models;
using CSupporter.Shared.Infrastructure.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace CSupporter.Modules.Factures.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FactureContractorController : ControllerBase
    {
        private readonly IContractorAPIService _contractorAPIService;
        private readonly IFactureService _factureService;

        public FactureContractorController(IFactureService factureService, IContractorAPIService contractorAPIService)
        {
            _contractorAPIService = contractorAPIService;
            _factureService = factureService;
        }

        [HttpGet("{contractorId}")]
        public async Task<ActionResult<string>> Get(string contractorId)
        {
            var response = await _contractorAPIService.GetContractorByIdAsync<APIResponse>(contractorId);

            ContractorDto contractorDto = new();
            if (response != null && response.IsSuccess)
            {
                contractorDto = JsonConvert.DeserializeObject<ContractorDto>(Convert.ToString(response.Result));
            }

            return Ok("Facture Works!");
        }
    }
}
