using System;

namespace BuilderPattern
{
    class Program
    {
        static Product customCar;
        static void Main(string[] args)
        {
            Console.WriteLine("Builder Pattern implementation");
            customCar = new Car("Suzuki Swift").StartUpOperations()
                                               .AddHeadlights(6)
                                               .InsertWheels()
                                               .BuildBody("Plastic")
                                               .EndOperations("Suzuki construction Completed!")
                                               .ConstructCar();

            customCar.Show();

            Console.ReadLine();

        }
    }
}
