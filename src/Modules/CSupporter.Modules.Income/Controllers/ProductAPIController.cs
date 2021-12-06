using CSupporter.Modules.Products.Domain.Interfaces;
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
        private readonly IProductService _productService;

        public ProductAPIController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Product API Works!");
        }
    }
}
