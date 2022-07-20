using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Treinando_api.Models;
using Treinando_api.Services;

namespace Treinando_api.Controllers;
[ApiController]
[Route("[controller]")]
public class FilterNameController : Microsoft.AspNetCore.Mvc.ControllerBase
{

    PersonService service = new PersonService();

    [HttpGet]
    public async Task<ActionResult<MarvelResponse>> GetObject()
    {
        var jsonReturn = await service.GetDataApi();
        var characters = JsonConvert.DeserializeObject<MarvelResponse>(jsonReturn);
        foreach (var character in characters.Data.Results)
        {
            Console.WriteLine(character.Name + " " + character.Description);
        }

        return Ok(characters);
    }

}
