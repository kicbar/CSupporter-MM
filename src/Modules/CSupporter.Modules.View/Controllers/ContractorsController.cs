using CSupporter.Modules.Contractors.DTO;
using CSupporter.Modules.View.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSupporter.Modules.View.Controllers
{
    public class ContractorsController : Controller
    {
        private readonly IRequestSenderService _requestSenderService;

        public ContractorsController(IRequestSenderService requestSenderService)
        {
            _requestSenderService = requestSenderService;
        }

        public async Task<IActionResult> ContractorsIndex()
        {
            List<ContractorDto> contractorsDto = new List<ContractorDto>();
            var response = await _requestSenderService.SendGetRequest();
            return View(response);
        }

    }
}
