using System;

namespace SimpleFactoryPattern
{
    public class SimpleFactory
    {
        public IAnimal CreateAnimal()
        {
            IAnimal intendedAnimal = null;
            Console.WriteLine("Enter your choice(0 for Dog, 1 for Tiger)");
            string choice = Console.ReadLine();

            if (int.TryParse(choice, out int input))
            {
                Console.WriteLine("You have entered {0}", input);

                switch (input)
                {
                    case 0:
                        intendedAnimal = new Dog();
                        break;
                    case 1:
                        intendedAnimal = new Tiger();
                        break;
                    default:
                        Console.WriteLine("You must enter either 0 or 1");
                        throw new ApplicationException(string.Format("Unknown Animal cannot be instantiated."));

                }
            }

            return intendedAnimal;
        }
    }
}
