﻿using Microsoft.AspNetCore.Mvc;
using Treinando_api.Services;

namespace Treinando_api.Controllers;
[ApiController]
[Route("[controller]")]

public class FilterNameController : ControllerBase
{
    PersonService service = new PersonService();
    [HttpGet]
    public ActionResult<string> a (){
         
        return "chato";  

        }









}