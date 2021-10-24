using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CSupporter.Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("IT Works!");
        }
    }
}
