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
    [Route("[controller]")]
    public class FactureController : ControllerBase
    {
        private readonly IFactureService _factureService;

        public FactureController(IFactureService factureService)
        {
            _factureService = factureService;
        }

        [HttpGet]
        [ActionName("GetAllFactures")]
        public ActionResult<List<FactureDto>> GetAllFactures()
        {
            return Ok(_factureService.GetAllFactures());
        }
    }
}