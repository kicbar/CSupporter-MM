using Microsoft.AspNetCore.Mvc;

namespace CSupporter.Modules.Contractors.Controllers
{

    public class ContractorsController : BaseController
    {
        [HttpGet]
        public ActionResult<string> Get() => "Hello Contracors!";
    }
}
