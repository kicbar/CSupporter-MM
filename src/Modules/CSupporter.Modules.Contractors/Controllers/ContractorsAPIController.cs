using CSupporter.Modules.Contractors.DTO;
using CSupporter.Modules.Contractors.Services.Abstractions;
using CSupporter.Shared.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSupporter.Modules.Contractors.Controllers
{
    [ApiController]
    [Route("api/contractor")]
    public class ContractorsAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IContractorService _contractorService;

        public ContractorsAPIController(IContractorService contractorService)
        {
            this._response = new APIResponse();
            _contractorService = contractorService;
        }

        [HttpGet("{id}")]
        public async Task<object> GetAPIContractor(Guid id)
        {
            try
            {
                ContractorDetailsDto contractorDetailsDto = await _contractorService.GetAsync(id);
                _response.Result = contractorDetailsDto;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }


        [HttpGet]
        public async Task<object> GetAPIAllContractors()
        {
            try
            {
                IEnumerable<ContractorDto> contractorsDetailsDto = await _contractorService.GetAllAsync();
                _response.Result = contractorsDetailsDto;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }
    }
}