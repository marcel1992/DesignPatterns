namespace BridgePattern
{
    public abstract class ElectronicGoods
    {
        private IPrice _price;
        public string type;
        public double cost;

        public ElectronicGoods(IPrice price)
        {
            _price = price;
        }

        public void Details()
        {
            _price.DisplayDetails(type, cost);
        }

        public void Discount(int percentage)
        {
            _price.GetDiscount(percentage);
        }
    }
}
