using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSupporter.Modules.View.Controllers
{
    public class IncomesController : Controller
    {
        public async Task<IActionResult> IncomesIndex()
        {
            return View();
        }
    }
}
