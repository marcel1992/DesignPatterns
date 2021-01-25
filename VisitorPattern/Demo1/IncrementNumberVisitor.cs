using System;

namespace VisitorPattern
{
    public class IncrementNumberVisitor : IVisitor
    {
        public void VisitNumbers(SmallNumber number)
        {
            Number currentNumber = number as Number;
            int temp = currentNumber.NumberValue;

            //for small number increment by 1
            Console.WriteLine($"{currentNumber.TypeInfo} is {currentNumber.NumberValue}; I use it as: {++temp} for the rest of my code.");
        }

        public void VisitNumbers(BigNumber number)
        {
            Number currentNumber = number as Number;
            int temp = currentNumber.NumberValue;

            //for small number increment by 10
            Console.WriteLine($"{currentNumber.TypeInfo} is {currentNumber.NumberValue}; I use it as: {temp + 10} for the rest of my code.");
        }
    }
}
