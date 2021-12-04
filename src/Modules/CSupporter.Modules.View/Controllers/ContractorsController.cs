using CSupporter.Modules.Contractors.DTO;
using CSupporter.Modules.View.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
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
            List<ContractorDto> contractorsDto = await _requestSenderService.SendGetAllRequest();
            return View(contractorsDto);
        }


        public async Task<IActionResult> ContractorCreate()
        {
            return View();
        }

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

        public async Task<IActionResult> ContractorEdit(Guid contractorId)
        {
            ContractorDto contractorDto = await _requestSenderService.SendGetRequest(contractorId);
            if (contractorDto != null)
                return View(contractorDto);

            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ContractorEdit(ContractorDto contractorDto)
        {
            if (ModelState.IsValid)
            {
                var response = await _requestSenderService.SendUpdateRequest(contractorDto);
                if (response != null)
                {
                    return RedirectToAction(nameof(ContractorsIndex));
                }
            }
            return View(contractorDto);
        }

        public async Task<IActionResult> ContractorDelete(Guid contractorId)
        {
            var response = await _requestSenderService.SendDeleteRequest(contractorId);

            return RedirectToAction(nameof(ContractorsIndex));
        }
    }
}
