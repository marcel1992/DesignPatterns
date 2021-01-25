using System;
using System.Collections.Generic;

namespace VisitorPattern.VisitorWithCompositePattern
{
    public class CompositeEmployee : IEmployee
    {
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Designation { get; set; }
        public double Experience { get; set; }

        //the container for child objects
        public List<IEmployee> subordinateList = new List<IEmployee>();

        //add employee
        public void AddEmployee(IEmployee employee)
        {
            subordinateList.Add(employee);
        }

        //remove employee
        public void RemoveEmployee(IEmployee employee)
        {
            subordinateList.Remove(employee);
        }

        //details of a composite node
        public void DisplayDetails()
        {
            Console.WriteLine($"{Name} works in {Dept} department. Designation: {Designation}. Experience: {Experience} years.");
            foreach (var employee in subordinateList)
            {
                employee.DisplayDetails();
            }
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitEmployees(this);
        }
    }
}