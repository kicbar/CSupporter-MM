using CSupporter.Modules.Factures.Domain.Interfaces;
using CSupporter.Shared.Infrastructure.Models;
using CSupporter.Shared.Infrastructure.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
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
        private readonly IFactureService _factureService;

        public FactureAPIController(IFactureService factureService)
        {
            this._response = new APIResponse();
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
    }
}