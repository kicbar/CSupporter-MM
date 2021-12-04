using CSupporter.Modules.Contractors.DTO;
using CSupporter.Modules.Contractors.Services.Abstractions;
using CSupporter.Shared.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSupporter.Modules.Contractors.Controllers
{
    public class ContractorsController : BaseController
    {
        protected APIResponse _response;
        private readonly IContractorService _contractorService;

        public ContractorsController(IContractorService contractorService)
        {
            this._response = new APIResponse();
            _contractorService = contractorService;
        }

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

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateContractors(Guid id, ContractorDto dto)
        {
            dto.Id = id;
            await _contractorService.UpdateAsync(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteContractors(Guid id)
        {
            await _contractorService.DeleteAsync(id);
            return NoContent();
        }
    }
}
