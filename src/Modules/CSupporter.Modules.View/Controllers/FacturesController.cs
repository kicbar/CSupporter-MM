using CSupporter.Modules.View.Models;
using CSupporter.Modules.View.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSupporter.Modules.View.Controllers
{
    public class FacturesController : Controller
    {
        private readonly IFactureAPIService _factureAPIService;

        public FacturesController(IFactureAPIService factureAPIService)
        {
            _factureAPIService = factureAPIService;
        }

        public async Task<IActionResult> FacturesIndex()
        {
            List<FacturesDto> facturesDto = await _factureAPIService.SendGetAllRequest();
            return View(facturesDto);
        }

        public async Task<IActionResult> FactureCreate()
        {
            return View();
        }

        public async Task<IActionResult> FactureEdit()
        {
            return View();
        }

        public async Task<IActionResult> FactureDelete()
        {
            return View();
        }
    }
}
