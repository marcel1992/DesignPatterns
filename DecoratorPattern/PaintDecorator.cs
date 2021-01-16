using System;

namespace DecoratorPattern
{
    public class PaintDecorator : AbstractDecorator
    {
        public PaintDecorator(AbstractHome home) : base(home)
        {
            AdditionalPrice = 5000;
        }

        public override void MakeHome()
        {
            //build original house
            base.MakeHome();
            //painting home
            PaintHome();
        }

        protected virtual void PaintHome()
        {
            Console.WriteLine($"Painting done. Pay additional {AdditionalPrice} for it.");
        }
    }
}
