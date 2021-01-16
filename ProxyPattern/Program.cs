using System;

namespace ProxyPattern
{
    class Program
    {
        /*
         * Decorators focus on adding responsibilities, whereas proxies focus on controlling access to an object!
         */ 
        static void Main(string[] args)
        {
            Console.WriteLine("Proxy Pattern");

            Subject proxy = null;

            //proxy = new Proxy();
            //proxy.DoSomeWork();

            //protection proxy
            proxy = new ProtectionProxy("Admin");
            proxy.DoSomeWork();

            proxy = new ProtectionProxy("Marcel");
            proxy.DoSomeWork();

            Console.ReadLine();
        }
    }
}
