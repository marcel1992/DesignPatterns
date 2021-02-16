namespace StrategyPattern
{
    public class Vehicle
    {
        VehicleBehavior behavior;
        string vehicleType;
        public Vehicle(string vehicleType)
        {
            this.vehicleType = vehicleType;
            //setting the initial behavior
            this.behavior = new InitialBehavior();
        }

        public void SetVehicleBehavior(VehicleBehavior behavior)
        {
            this.behavior = behavior;
        }

        /*This method will help us to delegate the behavior to the object referenced by vehicle.
         * You do not know about the object type, but you simply know that this object can tell something about it*/

        public void DisplayAboutMe()
        {
            behavior.AboutMe(vehicleType);
        }
    }
}
