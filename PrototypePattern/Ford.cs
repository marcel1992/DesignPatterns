namespace PrototypePattern
{
    public class Ford : BasicCar
    {
        public Ford(string modelName)
        {
            ModelName = modelName;
            //setting a basic price for ford
            BasePrice = 2000;
        }
        public override BasicCar Clone()
        {
            return this.MemberwiseClone() as Ford;
        }
    }
}
