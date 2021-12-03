using CSupporter.Modules.Factures.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CSupporter.Modules.Factures.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FactureController : ControllerBase
    {
        private readonly ILogger<FactureController> _logger;
        private readonly IFactureService _factureService;

        public FactureController(IFactureService factureService, ILogger<FactureController> logger)
        {
            _logger = logger;
            _factureService = factureService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Facture Works!");
        }
    }
}