﻿namespace BridgePattern
{
    //Implementor
    public interface IPrice
    {
        void DisplayDetails(string product, double price);
        void GetDiscount(int percentage);
    }
}