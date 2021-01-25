using System;

namespace VisitorPattern.VisitorWithCompositePattern
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Designation { get; set; }
        public double Experience { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitEmployees(this);
        }

        //details of a leaf node
        public void DisplayDetails()
        {
            Console.WriteLine($"{Name} works in {Dept} department. Designation: {Designation}. Experience: {Experience} years.");
        }
    }
}