using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bridge Pattern");

            #region Television details

            Console.WriteLine("Verifying the market price of a television");
            ElectronicGoods electronicGood = new Television(new OnlinePrice());
            //verify online price details
            electronicGood.Details();
            //giving 10% discount
            electronicGood.Discount(10);

            //verify showroom price
            electronicGood = new Television(new ShowroomPrice());
            electronicGood.Details();
            //giving 10% discount
            electronicGood.Discount(10);

            #endregion

            #region DVD details

            Console.WriteLine("Verifying the market price of a DVD");
            electronicGood = new DVD(new OnlinePrice());
            //verify online price details
            electronicGood.Details();
            //giving 10% discount
            electronicGood.Discount(10);

            //verify showroom price
            electronicGood = new DVD(new ShowroomPrice());
            electronicGood.Details();
            Console.WriteLine("In showroom, you want to give double discounts at festive season!");
            Console.WriteLine("For DVD you can get double discounts using the DoubleDiscount() method");
            ((DVD)electronicGood).DoubleDiscount();

            #endregion

            Console.Read();
        }
    }
}
