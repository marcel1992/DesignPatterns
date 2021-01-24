namespace BridgePattern
{
    public class Television : ElectronicGoods
    {
        public Television(IPrice price) : base(price)
        {
            type = "Television";
            cost = 2000;
        }
    }
}
