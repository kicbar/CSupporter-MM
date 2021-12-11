using CSupporter.Shared.Abstractions.IMessages.IServices;
using CSupporter.Shared.Infrastructure.Models;
using CSupporter.Shared.Infrastructure.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSupporter.Modules.View.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductAPIService _productAPIService;

        public ProductsController(IProductAPIService productAPIService)
        {
            _productAPIService = productAPIService;
        }

        public async Task<IActionResult> ProductsIndex()
        {
            var response = await _productAPIService.GetAllProducts<APIResponse>();

            List<ProductDto> productDtos = new();
            if (response != null && response.IsSuccess)
            {
                productDtos = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(response.Result));
            }

            return View(productDtos);
        }
    }
}
