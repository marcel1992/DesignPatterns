using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decorator Pattern");
            Console.WriteLine();

            #region Scenario 1

            Console.WriteLine("Scenario 1:");
            Console.WriteLine();
            Console.WriteLine("Building home. Adding floor and then painting it.");

            AbstractHome home = new ConcreteHome();
            Console.WriteLine("Current bill breakups are as follows:");
            home.MakeHome();

            //applying a decorator
            home = new FloorDecorator(home);
            //adding a floor
            Console.WriteLine("Floor added. Current bill breakups are as follows:");
            home.MakeHome();

            //working on top of the previous decorator
            home = new PaintDecorator(home);
            //painting the home
            Console.WriteLine("Paint applied. Current bill breakups are as follows:");
            home.MakeHome();

            #endregion

            #region Scenario 2

            Console.WriteLine("Scenario 2:");
            Console.WriteLine();
            Console.WriteLine("Building home. Painting it and the adding two additional floors on top of it.");

            //create the new house
            home = new ConcreteHome();
            Console.WriteLine("Current bill breakups are as follows:");
            home.MakeHome();

            //applying paint to original house
            home = new PaintDecorator(home);
            Console.WriteLine("Paint applied. Current bill breakups are as follows:");
            home.MakeHome();

            //adding a floor on the painted home
            home = new FloorDecorator(home);
            Console.WriteLine("Floor added. Current bill breakups are as follows:");
            home.MakeHome();

            //adding another floor on the current home
            home = new FloorDecorator(home);
            Console.WriteLine("Floor added. Current bill breakups are as follows:");
            home.MakeHome();

            #endregion

            Console.Read();
        }
    }
}
