using System;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Factory Pattern");
            IAnimal preferredType = null;

            SimpleFactory simpleFactory = new SimpleFactory();

            #region The code region that can vary based on users preference

            //since this part may vary, we're moving the part to CreateAnimal() in SimpleFactory class

            preferredType = simpleFactory.CreateAnimal();

            #endregion

            #region The code that do not change frequently

            preferredType.AboutMe();

            #endregion


            Console.ReadLine();
        }
    }
}
