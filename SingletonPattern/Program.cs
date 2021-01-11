using SingletonPattern.Environment;
using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //single thread environment
            Console.WriteLine("Singleton pattern demonstation");
            Console.WriteLine($"The value of MyInt is {Singleton.TotalInstances}");
            Console.WriteLine($"The value of MyInt is {Singleton.TotalInstances}");
            Console.Read();
        }
    }
}
