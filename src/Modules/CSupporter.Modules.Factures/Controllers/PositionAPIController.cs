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
    [Route("api/position")]
    public class PositionAPIController : Controller
    {
        protected APIResponse _response;
        private readonly IPositionService _positionService;

        public PositionAPIController(IPositionService positionService)
        {
            this._response = new APIResponse();
            _positionService = positionService;
        }

        [HttpGet]
        [Route("factureId")]
        [ActionName("GetAllPositionsForFacture")]
        public async Task<object> GetAllPositionsForFacture(int factureId)
        {
            try
            {
                List<PositionDto> positionsDto = _positionService.GetAllPositionsForFacture(factureId);
                _response.Result = positionsDto;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost]
        [ActionName("CreatePositionForFacture")]
        public async Task<object> CreatePositionForFacture([FromBody] PositionDto positionDto, int factureId)
        {
            try
            {
                PositionDto positionCreated = _positionService.AddPositionToFacture(positionDto, factureId);
                _response.Result = positionCreated;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpDelete]
        [Route("factureId")]
        [ActionName("RemovePositionFromFacture")]
        public ActionResult<PositionDto> RemovePositionFromFacture(int positionId)
        {
            return Ok(_positionService.RemovePositionFromFacture(positionId));
        }
    }
}
