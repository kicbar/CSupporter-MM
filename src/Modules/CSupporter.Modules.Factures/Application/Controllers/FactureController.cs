using CSupporter.Modules.Factures.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSupporter.Modules.Factures.Application.Controllers
{
    [ApiController]
    public class FactureController : ControllerBase
    {
        private readonly IFactureService _factureService;

        public FactureController(IFactureService factureService)
        {
            _factureService = factureService;
        }
    }
}
