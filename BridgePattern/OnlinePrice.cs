using System;

namespace BridgePattern
{
    public class OnlinePrice : IPrice
    {
        public void DisplayDetails(string product, double price)
        {
            Console.WriteLine($"{product} online price is: {price}$.");
        }

        public void GetDiscount(int percentage)
        {
            Console.WriteLine($"Online, you can get up to {percentage}% discount.");
        }
    }
}
