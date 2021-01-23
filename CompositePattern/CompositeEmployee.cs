using System;
using System.Collections.Generic;

namespace CompositePattern
{
    //non-leaf node
    public class CompositeEmployee : IEmployee
    {
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Designation { get; set; }

        //the container for child objects
        private List<IEmployee> subordinateList = new List<IEmployee>();

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
            Console.WriteLine($"{Name} works in {Dept} department. Designation: {Designation}");
            foreach (var employee in subordinateList)
            {
                employee.DisplayDetails();
            }
        }
    }
}
