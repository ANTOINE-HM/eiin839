using System;
using System.Text.Json;

namespace MyClient
{

    public class Contract
    {
        public string name { get; set; }
        public string commercial_name { get; set; }
        public List<string> cities { get; set; }
        public string country_code { get; set; }
    }



    internal class Program
    {
        static readonly HttpClient client = new HttpClient();
       
        static async Task Main(string[] args)
        {
            string api_key = "cfe9a0679020b361f73a04113fae576b56ae6ed8";
            HttpResponseMessage response = await client.GetAsync($"https://api.jcdecaux.com/vls/v3/contracts?apiKey={api_key}");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            List<Contract> jsonData = JsonSerializer.Deserialize<List<Contract>>(responseBody);

            foreach (Contract element in jsonData)
            {
                Console.WriteLine($"{element.name} - {element.commercial_name}");
            }
        }
    }
}
