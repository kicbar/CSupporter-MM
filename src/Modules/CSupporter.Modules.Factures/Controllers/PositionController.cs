using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSupporter.Modules.Factures.Controllers
{
    [ApiController]
    [Route("api/facture/{factureId}/position")]
    public class PositionController : ControllerBase
    {
        public PositionController()
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Facture Position Works!");
        }
    }
}
