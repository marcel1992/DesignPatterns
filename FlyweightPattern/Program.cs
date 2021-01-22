using System;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Flyweight Pattern");
            VehicleFactory vehicleFactory = new VehicleFactory();
            IVehicle vehicle;

            //now we are trying to get the 3 cars. Note that: we don't need to create additional cars
            // if we have already created one of this category

            for (int i = 0; i < 3; i++)
            {
                vehicle = vehicleFactory.GetVehicleFromVehicleFactory("car");
                vehicle.AboutMe(GetRandomColor());
            }

            int numberOfDistinctVehicles = vehicleFactory.TotalObjectsCreated;
            Console.WriteLine($"Now, total numbers of distinct vehicle object(s) is: {numberOfDistinctVehicles}");

            //5 more buses
            for (int i = 0; i < 5; i++)
            {
                vehicle = vehicleFactory.GetVehicleFromVehicleFactory("bus");
                vehicle.AboutMe(GetRandomColor());
            }
            numberOfDistinctVehicles = vehicleFactory.TotalObjectsCreated;
            Console.WriteLine($"Now, total numbers of distinct vehicle object(s) is: {numberOfDistinctVehicles}");

            //2 future vehicles
            for (int i = 0; i < 2; i++)
            {
                vehicle = vehicleFactory.GetVehicleFromVehicleFactory("future");
                vehicle.AboutMe(GetRandomColor());
            }

            numberOfDistinctVehicles = vehicleFactory.TotalObjectsCreated;
            Console.WriteLine($"Now, total numbers of distinct vehicle object(s) is: {numberOfDistinctVehicles}");

            Console.Read();
        }

        private static string GetRandomColor()
        {
            Random r = new Random();
            int random = r.Next(100);
            if (random % 2 == 0)
                return "red";
            else
                return "green";
        }
    }
}
