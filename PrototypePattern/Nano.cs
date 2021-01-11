namespace PrototypePattern
{
    public class Nano : BasicCar
    {
        public Nano(string modelName)
        {
            ModelName = modelName;
            //setting a base price for nano
            BasePrice = 1000;
        }

        public override BasicCar Clone()
        {
            //create a shallow copy and returning it
            return this.MemberwiseClone() as Nano;
        }
    }
}
