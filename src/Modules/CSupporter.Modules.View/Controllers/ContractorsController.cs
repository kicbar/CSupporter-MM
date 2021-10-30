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
            var response = await _requestSenderService.SendGetAllRequest();
            return View(response);
        }

        public async Task<IActionResult> ContractorCreate()
        {
            return View();
        }

        public async Task<IActionResult> ContractorEdit()
        {
            return View();
        }

        public async Task<IActionResult> ContractorDelete()
        {
            return View();
        }
    }
}
