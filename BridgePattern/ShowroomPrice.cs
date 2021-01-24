using System;

namespace BridgePattern
{
    public class ShowroomPrice : IPrice
    {
        public void DisplayDetails(string product, double price)
        {
            Console.WriteLine($"{product} online price is: {price + 300}$.");
        }

        public void GetDiscount(int percentage)
        {
            Console.WriteLine($"In showroom, additional {percentage}% discount can be approved.");
        }
    }
}
