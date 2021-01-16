using System;

namespace ProxyPattern
{
    class Program
    {
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
