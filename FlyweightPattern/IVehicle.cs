namespace FlyweightPattern
{
    public interface IVehicle
    {
        //client will supply the color
        //it is extrinsic state
        void AboutMe(string color);
    }
}
