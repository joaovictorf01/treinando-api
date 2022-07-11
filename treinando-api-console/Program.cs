using Newtonsoft.Json;
using System.Text.Json;

public class Program
{
    public static async Task Main()

    {

        PersonService service = new PersonService();
        var jsonReturn = await service.GetDataApi();
        var characters = JsonConvert.DeserializeObject<MarvelResponse>(jsonReturn);
        foreach (var character in characters.Data.Results)           
        Console.WriteLine(character.Name +" "+ character.Description);

    }

}