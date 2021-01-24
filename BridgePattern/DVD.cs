namespace BridgePattern
{
    public class DVD : ElectronicGoods
    {
        public DVD(IPrice price) : base(price)
        {
            type = "DVD";
            cost = 3000;
        }

        public void DoubleDiscount()
        {
            //normal discount 10%
            Discount(10);
            //festive season additional discount
            Discount(5);
        }
    }
}
