using CSupporter.Modules.Contractors.DTO;
using CSupporter.Modules.Contractors.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CSupporter.Modules.Contractors.Controllers
{

    public class ContractorsController : BaseController
    {
        private readonly IContractorService _contractorService;

        public ContractorsController(IContractorService contractorService)
        {
            _contractorService = contractorService;
        }

        [HttpGet]
        public ActionResult<string> Get() => "Hello Contracors!";

        [HttpGet("{id}")]
        public async Task<ActionResult<ContractorDetailsDto>> GetContractor(Guid id)
        {
            return await _contractorService.GetAsync(id);
        }

    }
}
