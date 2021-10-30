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
        /*        [HttpPost]
                public async Task<IActionResult> ContractorCreate(ContractorDto contractorDto)
                {
                    var response = await _requestSenderService.SendPostRequest(contractorDto);
                    return View(response);
                }*/

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ContractorCreate(ContractorDto contractorDto)
        {
            if (ModelState.IsValid)
            {
                var response = await _requestSenderService.SendPostRequest(contractorDto);
                if (response != null)
                {
                    return RedirectToAction(nameof(ContractorsIndex));
                }
            }
            return View(contractorDto);
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
