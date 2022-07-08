using Treinando_api.Models;
using System;

namespace Treinando_api.Services;

public class PersonService
{
    
    HttpClient client = new HttpClient();

    public async Task<object> GetDataApi()
    {

        var responseMessage = await client.GetAsync("https://gateway.marvel.com/v1/public/characters?ts=yourtsvalue&apikey=publickeyvalue&hash=hashvalue");

        Console.WriteLine( await responseMessage.Content.ReadAsStringAsync());
        string result=await responseMessage.Content.ReadAsStringAsync();
        return result;
    }

    


}
