using System;
using System.Text.Json;

namespace MyClient
{

    public class Position
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    public class Station
    {
        public int number { get; set; }
        public string contract_name { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public Position position { get; set; }
        public bool banking { get; set; }
        public bool bonus { get; set; }
        public string status { get; set; }
    }



    internal class Program
    {
        static readonly HttpClient client = new HttpClient();



        static async Task Main(string[] args)
        {
            string api_key = "cfe9a0679020b361f73a04113fae576b56ae6ed8";
            HttpResponseMessage response = await client.GetAsync($"https://api.jcdecaux.com/vls/v3/stations?contract={args[0]}&apiKey={api_key}");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            List<Station> jsonData = JsonSerializer.Deserialize<List<Station>>(responseBody);

            Console.WriteLine("liste des stations de " + args[0]);

            foreach (Station element in jsonData)
            {
                Console.WriteLine($"{element.number} -{element.name}");
            }
        }
    }
}
