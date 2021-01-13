using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Pattern");

            //create a factory that can produce animals
            AnimalFactory animalFactory = new ConcreteAnimalFactory();
            //create a tiger using the factory method
            IAnimal tiger = animalFactory.CreateAnimal("tiger");
            tiger.AboutMe();

            //create a dog using the factory method
            IAnimal dog = animalFactory.CreateAnimal("dog");
            dog.AboutMe();

            Console.ReadLine();
        }
    }
}
