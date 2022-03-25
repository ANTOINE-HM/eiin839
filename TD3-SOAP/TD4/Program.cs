using ServiceReference1;

namespace TD3SOAP
{

    internal class CallSOAP
    {
        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            var client = new ServiceReference2.MathsOperationsClient(ServiceReference2.MathsOperationsClient.EndpointConfiguration.BasicHttpBinding_IMathsOperations);
            int a = 12;
            int b = 8;
            Console.WriteLine("Voici l'addition de " + a + " et " + b);
            Console.WriteLine(await client.ChannelFactory.CreateChannel().AddAsync(a, b));
            Console.WriteLine("Voici la multiplicatiion de " + a + " et " + b);
            Console.WriteLine(await client.ChannelFactory.CreateChannel().MultiplyAsync(a, b));
            Console.WriteLine("Voici la soustraction de " + a + " et " + b);
            Console.WriteLine(await client.ChannelFactory.CreateChannel().SubstractAsync(a, b));
        }
    }
}
