using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype pattern");
            CarFactory carFactory = new CarFactory();
            //get a Nano
            BasicCar basicCar = carFactory.GetNano();
            //working on cloned copy
            basicCar.OnRoadPrice = basicCar.BasePrice + BasicCar.SetAdditionalPrice();
            Console.WriteLine($"Car is: {basicCar.ModelName}, and it's price is {basicCar.OnRoadPrice}");

            //get a Ford
            basicCar = carFactory.GetFord();
            //working on cloned copy
            basicCar.OnRoadPrice = basicCar.BasePrice + BasicCar.SetAdditionalPrice();
            Console.WriteLine($"Car is: {basicCar.ModelName}, and it's price is {basicCar.OnRoadPrice}");

            Console.ReadLine();
        }
    }
}
