using Microsoft.AspNetCore.Mvc;
namespace Treinando_api.Controllers;
[ApiController]
[Route("[controller]")]

public class FilterNameController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> GetAction()
    {
        return Content(" test");
    }
    

}


