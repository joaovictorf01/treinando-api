using System;

public class Program
{
    public static async Task Main()
    {
PersonService service= new PersonService();
  await service.GetDataApi();
        Console.WriteLine("teologia");

    }

}