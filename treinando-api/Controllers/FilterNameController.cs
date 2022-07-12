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
    

        Person characters = JsonConvert.DeserializeObject<MarvelResponse>(jsonReturn);

}