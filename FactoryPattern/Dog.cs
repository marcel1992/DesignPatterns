using System;

namespace FactoryPattern
{
    public class Dog : IAnimal
    {
        public void AboutMe()
        {
            Console.WriteLine("The dog says: I prefer barking!");
        }
    }
}
