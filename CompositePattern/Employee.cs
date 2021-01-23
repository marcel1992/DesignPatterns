using System;

namespace CompositePattern
{
    //leaf node
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Designation { get; set; }

        //details of a leaf node
        public void DisplayDetails()
        {
            Console.WriteLine($"{Name} works in {Dept} department. Designation: {Designation}");
        }
    }
}
