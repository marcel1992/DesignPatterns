using System;

namespace FactoryPattern
{
    public class Tiger : IAnimal
    {
        public void AboutMe()
        {
            Console.WriteLine("The tiger says: I prefer hunting!");
        }
    }
}
