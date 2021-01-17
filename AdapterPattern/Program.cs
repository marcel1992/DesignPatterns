using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adapter Pattern");

            Console.WriteLine("For initial verification purposes, printing the ares of both shapes.");
            IRectangle rectangle = new Rectangle(20, 10);
            Console.WriteLine($"Rectangle area is: {rectangle.CalculateArea()} square unit");
            ITriangle triangle = new Triangle(20, 10);
            Console.WriteLine($"Triangle area is: {triangle.CalculateArea()} square unit");

            Console.WriteLine("Now using the adapter:");
            IRectangle adapter = new RectangleAdapter(triangle);
            Console.WriteLine("True fact: ");
            adapter.AboutMe();
            Console.WriteLine($" and my area is: {adapter.CalculateArea()} square unit");

            Console.Read();

        }
    }
}
