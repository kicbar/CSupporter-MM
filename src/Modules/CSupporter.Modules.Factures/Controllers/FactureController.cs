using CSupporter.Modules.Factures.Application.DTOs;
using CSupporter.Modules.Factures.Domain.Interfaces;
using CSupporter.Shared.Abstractions.IMessages.IServices;
using CSupporter.Shared.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace CSupporter.Modules.Factures.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FactureController : ControllerBase
    {
        private readonly Shared.Abstractions.IMessages.IServices.IContractorAPIService _contractorAPIService;
        private readonly IFactureService _factureService;

        public FactureController(IFactureService factureService, Shared.Abstractions.IMessages.IServices.IContractorAPIService contractorAPIService)
        {
            _contractorAPIService = contractorAPIService;
            _factureService = factureService;
        }

        [HttpGet]
        public async Task<ActionResult<string>> Get(Guid id)
        {
            var response = await _contractorAPIService.GetContractorByIdAsync<APIResponse>(id);

            ContractorDto contractorDto = new();
            if (response != null && response.IsSuccess)
            {
                contractorDto = JsonConvert.DeserializeObject<ContractorDto>(Convert.ToString(response.Result));
            }

            return Ok("Facture Works!");
        }
    }
}