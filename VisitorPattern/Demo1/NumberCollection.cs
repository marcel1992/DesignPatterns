using System.Collections.Generic;

namespace VisitorPattern
{
    public class NumberCollection
    {
        List<Number> numberList = new List<Number>();
        //list contains both small and big number's

        public NumberCollection()
        {
            numberList.Add(new SmallNumber("small-1", 10));
            numberList.Add(new SmallNumber("small-2", 20));
            numberList.Add(new SmallNumber("small-3", 30));
            numberList.Add(new BigNumber("big-1", 200));
            numberList.Add(new BigNumber("big-2", 150));
            numberList.Add(new BigNumber("big-3", 70));
        }

        public void DisplayList()
        {
            System.Console.WriteLine("Current list is as follows:");
            foreach (var item in numberList)
            {
                System.Console.WriteLine(item.NumberValue + "\t");
            }
            System.Console.WriteLine();
        }
        public void Accept(IVisitor visitor)
        {
            foreach (var item in numberList)
            {
                item.Accept(visitor);
            }
        }
    }
}
