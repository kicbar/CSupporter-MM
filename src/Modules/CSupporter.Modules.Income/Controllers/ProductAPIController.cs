using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSupporter.Modules.Products.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductAPIController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Product API Works!");
        }
    }
}
