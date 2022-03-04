using System.Text.Json;
using System.Text.Json.Serialization;

namespace ClientWeb
{
    public class ValueIncr
    {
        public string message { get; set; }
        public int value { get; set; }
    }
    public class ClientWeb
    {
        public static string url = "http://localhost:8080/incr?param1=2";
        static readonly HttpClient client = new HttpClient();

        public static async Task Main(string[] args)
        {
            var response = client.GetAsync(url);
            var responseBody = await response.Result.Content.ReadAsStringAsync();

            ValueIncr jsonData = JsonSerializer.Deserialize<ValueIncr>(responseBody);
            Console.Write(jsonData.message + jsonData.value);

        }
    }
}
