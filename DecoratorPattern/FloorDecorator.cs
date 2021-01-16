using System;

namespace DecoratorPattern
{
    public class FloorDecorator : AbstractDecorator
    {
        public FloorDecorator(AbstractHome home) : base(home)
        {
            AdditionalPrice = 2500;
        }
        public override void MakeHome()
        {
            //build original house
            base.MakeHome();

            //adding a floor on top of original house
            AddFloor();
        }

        protected virtual void AddFloor()
        {
            Console.WriteLine($"Additional Floor added. Pay additional {AdditionalPrice} for it.");
        }
    }
}
