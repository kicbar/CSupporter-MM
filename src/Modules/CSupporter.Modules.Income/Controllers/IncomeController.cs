using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CSupporter.Modules.Income.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IncomeController : ControllerBase
    {
        private readonly ILogger<IncomeController> _logger;

        public IncomeController(ILogger<IncomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Income Works!");
        }
    }
}
