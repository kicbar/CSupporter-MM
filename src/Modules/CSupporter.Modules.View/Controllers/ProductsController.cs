using CSupporter.Modules.View.Models;
using CSupporter.Modules.View.Services.IServices;
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
        private readonly IProductRequestService _productRequestService;

        public ProductsController(IProductRequestService productRequestService, IProductAPIService productAPIService)
        {
            _productAPIService = productAPIService;
            _productRequestService = productRequestService;
        }

        public async Task<IActionResult> ProductsIndex()
        {
            List<ProductDto> contractorsDto = await _productAPIService.SendGetAllRequest();
            return View(contractorsDto);
        }
    }
}
