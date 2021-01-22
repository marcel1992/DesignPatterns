using System;
using System.Collections.Generic;

namespace FlyweightPattern
{
    public class VehicleFactory
    {
        private Dictionary<string, IVehicle> vehicles = new Dictionary<string, IVehicle>();

        //to count different types of vehicles in a given moment
        public int TotalObjectsCreated => vehicles.Count;

        public IVehicle GetVehicleFromVehicleFactory(string vehicleType)
        {
            IVehicle vehicleCategory;
            if (vehicles.ContainsKey(vehicleType))
                vehicleCategory = vehicles[vehicleType];
            else
            {
                switch (vehicleType)
                {
                    case "car":
                        vehicleCategory = new Car("One car is created");
                        vehicles.Add("car", vehicleCategory);
                        break;
                    case "bus":
                        vehicleCategory = new Bus("One bus is created");
                        vehicles.Add("bus", vehicleCategory);
                        break;
                    case "future":
                        vehicleCategory = new FutureVehicle("Vehicle 2050 is created");
                        vehicles.Add("future", vehicleCategory);
                        break;
                    default:
                        throw new Exception("Vehicle Factory can give you cars and buses only.");
                }
            }

            return vehicleCategory;
        }

    }
}
