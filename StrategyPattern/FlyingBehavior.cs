using System;

namespace StrategyPattern
{
    public class FlyingBehavior : VehicleBehavior
    {
        public override void AboutMe(string vehicle)
        {
            Console.WriteLine($"My {vehicle} can fly now!");
        }
    }
}
