using System;

namespace BuilderPattern
{
    public class Car : IBuilder
    {
        Product product;

        private string brandName;
        public Car(string brand)
        {
            product = new Product();
            brandName = brand;
        }
        public IBuilder AddHeadlights(int optionalNumberOfHeadLights = 2)
        {
            product.Add($"Headlights: {optionalNumberOfHeadLights}");
            return this;
        }

        public IBuilder BuildBody(string optionalBodyType = "Steel")
        {
            product.Add($"Body type: {optionalBodyType}");
            return this;
        }

        public Product ConstructCar()
        {
            return product;
        }

        public IBuilder EndOperations(string optionalEndMessage = "Car construction is complete.")
        {
            product.Add(optionalEndMessage);
            return this;
        }

        public IBuilder InsertWheels(int optionalNumberOfWheels = 4)
        {
            product.Add(optionalNumberOfWheels.ToString());
            return this;

        }

        public IBuilder StartUpOperations(string optionalStartupMessage = "Making a car for you.")
        {
            product.Add(optionalStartupMessage);
            product.Add($"Car model name: {brandName}");
            return this;
        }
    }
}
