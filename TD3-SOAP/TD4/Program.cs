using ServiceReference1;

namespace TD3SOAP
{

    internal class CallSOAP
    {
        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            var client = new ServiceReference1.CalculatorSoapClient(CalculatorSoapClient.EndpointConfiguration.CalculatorSoap);
            int a = 12;
            int b = 8;
            Console.WriteLine("Voici l'addition de " + a + " et " + b);
            Console.WriteLine(await client.ChannelFactory.CreateChannel().AddAsync(a, b));
        }
    }
}
