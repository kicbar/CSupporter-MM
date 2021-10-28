using Microsoft.AspNetCore.Mvc;

namespace CSupporter.Modules.Contractors.Controllers
{
    [ApiController]
    [Route(template: BasePath + "[controller]")]
    public class BaseController : ControllerBase
    {
        protected const string BasePath = "contractors-module/";

        protected ActionResult<T> OkOrNotFound<T>(T model)
        {
            if (model is null)
            {
                return NotFound();
            }

            return Ok(model);
        }
    }
}
