using CSupporter.Modules.Factures.Domain.Interfaces;
using CSupporter.Shared.Abstractions.IMessages.IServices;
using CSupporter.Shared.Infrastructure.Models;
using CSupporter.Shared.Infrastructure.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSupporter.Modules.Factures.Controllers
{
    [ApiController]
    [Route("api/facture")]
    public class FactureAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IContractorAPIService _contractorAPIService;
        private readonly IPositionService _positionService;
        private readonly IFactureService _factureService;
        
        public FactureAPIController(IFactureService factureService, IContractorAPIService contractorAPIService, IPositionService positionService)
        {
            this._response = new APIResponse();
            _contractorAPIService = contractorAPIService;
            _positionService = positionService;
            _factureService = factureService;
        }

        [HttpGet]
        [ActionName("GetAllFactures")]
        public async Task<object> GetAllFactures()
        {
            try
            {
                List<FactureDto> facturesDto = _factureService.GetAllFactures();
                _response.Result = facturesDto;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpGet("{factureId}")]
        [ActionName("GetFacture")]
        public async Task<object> GetFacture(int factureId)
        {
            try
            {
                FactureDto factureDto = _factureService.GetFacture(factureId);
                _response.Result = factureDto;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost]
        [ActionName("AddFacture")]
        public async Task<object> AddFacture([FromBody] FactureDto factureDto)
        {
            try
            {
                FactureDto fatureCreated = _factureService.AddFacture(factureDto);
                _response.Result = fatureCreated;
            }
            catch (Exception exc)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { exc.ToString() };
            }
            return _response;
        }


        [HttpPut]
        [ActionName("UpdateFacture")]
        public async Task<object> UpdateFacture([FromBody] FactureDto factureDto)
        {
            try
            {
                FactureDto factureUpdated =  _factureService.UpdateFacture(factureDto);
                _response.Result = factureUpdated;
            }
            catch (Exception exc)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { exc.ToString() };
            }
            return _response;
        }

        [HttpDelete("{id}")]
        public async Task<object> DeleteFacture(int factureId)
        {
            try
            {
                bool isRemoved =  _factureService.DeleteFacture(factureId);
                _response.Result = isRemoved;
            }
            catch (Exception exc)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { exc.ToString() };
            }
            return _response;
        }

        [HttpGet]
        [Route("details/{factureId}")]
        [ActionName("GetFactureDetails")]
        public async Task<ActionResult<EntireFactureDto>> GetFactureDetails(int factureId)
        {
            EntireFactureDto entireFactureDto = new();
            FactureDto factureDto = _factureService.GetFacture(factureId);
            if (factureDto != null)
            {
                entireFactureDto.FactureId = factureDto.FactureId;
                entireFactureDto.FactureNo = factureDto.FactureNo;
                entireFactureDto.FactureType = factureDto.FactureType;
                entireFactureDto.FactureDate = factureDto.FactureDate;
                entireFactureDto.FactureValue = factureDto.Value;

                var response = await _contractorAPIService.GetContractorByIdAsync<APIResponse>(factureDto.ContractorId);

                ContractorDto contractorDto = new();
                if (response != null && response.IsSuccess)
                {
                    contractorDto = JsonConvert.DeserializeObject<ContractorDto>(Convert.ToString(response.Result));
                }

                if (response != null)
                {
                    //ContractorDto contractorDtoModel = JsonConvert.DeserializeObject<ContractorDto>(Convert.ToString(contractorDto));
                    entireFactureDto.ContractorFirstName = contractorDto.FirstName;
                    entireFactureDto.ContractorLastName = contractorDto.LastName;
                    entireFactureDto.ContractorCompanyName = contractorDto.CompanyName;
                    entireFactureDto.ContractorAddress = contractorDto.Address;
                    entireFactureDto.ContractorNIP = contractorDto.NIP;
                }
                else
                    return NotFound();

                List<PositionDto> positionDtos = _positionService.GetAllPositionsForFacture(factureId);
                entireFactureDto.Positions = positionDtos;
            }
            else
                return NotFound();

            return entireFactureDto;
        }
    }
}