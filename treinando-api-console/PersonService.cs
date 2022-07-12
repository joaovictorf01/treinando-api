using System.Text;
using System.Security.Cryptography;

public class PersonService
{
    string ts = DateTime.Now.Ticks.ToString();

    string publicKey = "217cd5c2d5a07a962fc8760565aeca83";
string privateKey = "b45c336c0793c7d5708628390bc9383e90ac7a01";
    private string GerarHash(
                string ts, string publicKey, string privateKey){
    
        byte[] bytes =
            Encoding.UTF8.GetBytes(ts + privateKey + publicKey);
        var gerador = MD5.Create();
        byte[] bytesHash = gerador.ComputeHash(bytes);
        return BitConverter.ToString(bytesHash)
            .ToLower().Replace("-", String.Empty);
    }


    

    HttpClient client = new HttpClient();

    public async Task<string> GetDataApi()
    {

         var responseMessage = await client.GetAsync("https://gateway.marvel.com/v1/public/characters?ts=" + ts + "&apikey=" + publicKey + "&hash=" + GerarHash(ts, publicKey, privateKey));       
            //Console.WriteLine(await responseMessage.Content.ReadAsStringAsync());
            string result = await responseMessage.Content.ReadAsStringAsync();
            return result;
        
    }




}
