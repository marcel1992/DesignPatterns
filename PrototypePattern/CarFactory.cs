namespace PrototypePattern
{
    public class CarFactory
    {
        private BasicCar nano, ford;
        public BasicCar GetNano()
        {
            if (nano != null)
            {
                //Nano was created earlier
                //returning a clone of it
                return nano.Clone();
            }
            else
            {
                //create a nano for the first time and return it
                nano = new Nano("Green Nano");
                return nano;
            }
        }

        public BasicCar GetFord()
        {
            if(ford != null)
            {
                return ford.Clone();
            }
            else
            {
                ford = new Ford("Yellow Ford");
                return ford;
            }
        }
    }
}
