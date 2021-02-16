using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Template Method Pattern");
            BasicEngineering basicEngineering = new ComputerScience();
            Console.WriteLine("Computer science course includes the following subjects:");
            basicEngineering.DisplayCourseStructure();
            Console.WriteLine();

            basicEngineering = new Electronics();
            Console.WriteLine("Electronics course includes the following subjects:");
            basicEngineering.DisplayCourseStructure();
            Console.Read();
        }
    }
}
