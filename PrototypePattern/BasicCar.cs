using System;

namespace PrototypePattern
{
    public abstract class BasicCar
    {
        public int BasePrice = 0, OnRoadPrice = 0;
        public string ModelName { get; set; }

        //We'll add this price before the final calculation of OnRoadPrice
        public static int SetAdditionalPrice()
        {
            Random random = new Random();
            int additionalPrice = random.Next(2000, 5000);
            return additionalPrice;
        }
        public abstract BasicCar Clone();

    }
}
