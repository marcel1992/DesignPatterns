using System;

namespace StrategyPattern
{
    public class InitialBehavior : VehicleBehavior
    {
        public override void AboutMe(string vehicle)
        {
            Console.WriteLine($"My {vehicle} is just born. It cannot do anything");
        }
    }
}
