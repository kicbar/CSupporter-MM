using CSupporter.Modules.Contractors.DTO;
using CSupporter.Modules.Contractors.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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

/*        [HttpGet]
        public ActionResult<string> Get() => "Hello Contracors!";*/

        [HttpGet("{id}")]
        public async Task<ActionResult<ContractorDetailsDto>> GetContractor(Guid id)
            => OkOrNotFound(await _contractorService.GetAsync(id));

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<ContractorDto>>> GetAllContractors()
            => Ok(await _contractorService.GetAllAsync());

        [HttpPost]
        public async Task<ActionResult> PostContractors(ContractorDto dto)
        {
            await _contractorService.AddAsync(dto);
            return CreatedAtAction(nameof(GetContractor), routeValues: new {id = dto.Id}, value: null);
        }
    }
}
