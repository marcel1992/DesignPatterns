using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy Pattern!");
            Vehicle context = new Vehicle("Airplane");
            context.DisplayAboutMe();
            Console.WriteLine("Setting flying capability to vehicle");
            context.SetVehicleBehavior(new FlyingBehavior());
            context.DisplayAboutMe();
            Console.WriteLine("Setting floating capability to vehicle");
            context.SetVehicleBehavior(new FloatBehavior());
            context.DisplayAboutMe();
            Console.Read();
        }
    }
}
