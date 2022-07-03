using Treinando_api.Models;
using System;

namespace Treinando_api.Services;

public class PersonService
{
    public string data;
    HttpClient client = new HttpClient();

    public async Task<string> GetDataapi()
    {

        var responseMessage = await client.GetAsync("http://gateway.marvel.com/v1/public/comics");

        data = responseMessage.ToString();
        Console.WriteLine(data);    

        return data;
    }





}
