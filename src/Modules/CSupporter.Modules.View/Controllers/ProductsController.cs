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

        public ProductsController(IProductAPIService productAPIService)
        {
            _productAPIService = productAPIService;
        }

        public async Task<IActionResult> ProductsIndex()
        {
            List<ProductDto> contractorsDto = await _productAPIService.SendGetAllRequest();
            return View(contractorsDto);
        }

        public async Task<IActionResult> ProductCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ContractorCreate(ProductDto productDto)
        {
            if (ModelState.IsValid)
            {
                var response = await _productAPIService.SendPostRequest(productDto);
                if (response != null)
                {
                    return RedirectToAction(nameof(ProductsIndex));
                }
            }
            return View(productDto);
        }

        public async Task<IActionResult> ProductEdit()
        {
            return View();
        }

        public async Task<IActionResult> ProductDelete()
        {
            return View();
        }
    }
}
