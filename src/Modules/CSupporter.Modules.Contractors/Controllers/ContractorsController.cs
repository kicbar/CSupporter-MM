using Microsoft.AspNetCore.Mvc;

namespace CSupporter.Modules.Contractors.Controllers
{
    [Route(template:"contractors-module")]
    public class ContractorsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get() => "Hello Contracors!";
    }
}
