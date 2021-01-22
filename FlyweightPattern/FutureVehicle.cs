using System;

namespace FlyweightPattern
{
    public class FutureVehicle : IVehicle
    {
        /*
         * it is intrinsic state and it is independent of flyweight context
         * this can be shared
         * so, our factory method will supply this value inside the flyweight object
         */

        private string _description;

        //flyweight factory will supply this inside the flyweight object
        public FutureVehicle(string description)
        {
            _description = description;
        }

        //client cannot choose color for FutureVehicle since it's unshared flyweight, ignoring client's input
        public void AboutMe(string color)
        {
            Console.WriteLine($"{_description} with blue color.");
        }
    }
}
