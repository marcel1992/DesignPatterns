using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Factory Pattern");

            //making a wild dog and a wild tiger with WildAnimalFactory
            IAnimalFactory animalFactory = FactoryProvider.GetAnimalFactory(AnimalType.Wild);
            IDog dog = animalFactory.GetDog();
            ITiger tiger = animalFactory.GetTiger();
            dog.AboutMe();
            tiger.AboutMe();

            Console.WriteLine("--------------------------------------------------------");

            //making a pet dog and a pet tiger with PetAnimalFactory
            animalFactory = FactoryProvider.GetAnimalFactory(AnimalType.Pet);
            dog = animalFactory.GetDog();
            tiger = animalFactory.GetTiger();
            dog.AboutMe();
            tiger.AboutMe();

            Console.Read();
        }
    }
}
