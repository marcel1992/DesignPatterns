using System;

namespace FlyweightPattern
{
    public class Bus : IVehicle
    {
        /*
         * it is intrinsic state and it is independent of flyweight context
         * this can be shared
         * so, our factory method will supply this value inside the flyweight object
         */

        private string _description;

        //flyweight factory will supply this inside the flyweight object
        public Bus(string description)
        {
            _description = description;
        }

        //client will supply the color
        public void AboutMe(string color)
        {
            Console.WriteLine($"{_description} with {color} color.");
        }
    }
}
