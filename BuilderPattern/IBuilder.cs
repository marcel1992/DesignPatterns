using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IBuilder
    {
        /*
         * All the methods return types are IBuilder
         * This will help us to apply method chaining
         */

        IBuilder StartUpOperations(string optionalStartupMessage = "Making a car for you.");
        IBuilder BuildBody(string optionalBodyType = "Steel");
        IBuilder InsertWheels(int optionalNumberOfWheels = 4);
        IBuilder AddHeadlights(int optionalNumberOfHeadLights = 2);
        IBuilder EndOperations(string optionalEndMessage = "Car construction is complete.");
        //combine the parts and make the final product
        Product ConstructCar();
    }
}
