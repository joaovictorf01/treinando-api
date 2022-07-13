using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Treinando_api.Models;
using Treinando_api.Services;

namespace Treinando_api.Controllers;
[ApiController]
[Route("[controller]")]

public class FilterNameController : ControllerBase
{

    PersonService service = new PersonService();
    private string jsonReturn;
    public async Task<string> GetApi()
    {
        var jsonReturn = await service.GetDataApi();
        return jsonReturn;
    }
    public object CreatPerson()
    {
        var characters = JsonConvert.DeserializeObject<MarvelResponse>(jsonReturn);
        return characters;
    }

    [HttpGet]
    public ActionResult<MarvelData>(){

        return characters;
        }
}