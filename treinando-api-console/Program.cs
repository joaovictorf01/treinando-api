using System.Text.Json;

public class Program
{
    public static async Task Main()
    {

        PersonService service = new PersonService();
          var jsonReturn = await service.GetDataApi();
        Person character = JsonSerializer.Deserialize<Person>(jsonReturn);

        Console.WriteLine(character.name);
    }

}