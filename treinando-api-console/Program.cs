using System.Text.Json;

public class Program
{
    public static async Task Main()
    {

        PersonService service = new PersonService();
        var jsonReturn = await service.GetDataApi();

        var characters = JsonSerializer.Deserialize<IList<
        Person>>(jsonReturn);
        foreach (var character in characters)
        {
            Console.WriteLine(character.name + character.description);    
        }   
        

    }

}