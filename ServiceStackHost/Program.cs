using System;

namespace ServiceStackHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var appHost = new AppHost();
            appHost.Init();
            appHost.Start("http://*:1333/");
            Console.WriteLine("Press any key to stop the service.");
            Console.ReadKey();
        }
    }
}
