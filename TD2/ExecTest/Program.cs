using System;

namespace ExeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 1)
                Console.WriteLine("<html><body> Le classico " + args[0] + " vs " + args[1] + " </body></html>");
            else
                Console.WriteLine("ExeTest <string parameter>");
        }
    }
}
