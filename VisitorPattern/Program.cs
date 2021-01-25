using System;
using System.Collections.Generic;
using VisitorPattern.VisitorWithCompositePattern;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Visitor Pattern");

            #region Visitor pattern - simple

            NumberCollection numberCollection = new NumberCollection();
            //showing the current list
            numberCollection.DisplayList();

            IncrementNumberVisitor incrementNumberVisitor = new IncrementNumberVisitor();

            //visiting the list
            Console.WriteLine("IncrementNumberVisitor is about to visit the list:");
            numberCollection.Accept(incrementNumberVisitor);

            //showing the current list
            numberCollection.DisplayList();
            Console.WriteLine();
            Console.WriteLine();

            #endregion

            #region Visitor pattern - composite pattern

            #region Mathematics department

            //2 lecturers work in Mathematics department
            Employee mathTeacher1 = new Employee()
            {
                Name = "M. Joy",
                Dept = "Mathematic",
                Designation = "Lecturer",
                Experience = 13.7
            };
            Employee mathTeacher2 = new Employee()
            {
                Name = "M. Roony",
                Dept = "Mathematic",
                Designation = "Lecturer",
                Experience = 6.5
            };

            //the college has a Head of Department in Mathematics
            CompositeEmployee hodMathematic = new CompositeEmployee()
            {
                Name = "Mrs. S.Das",
                Dept = "Maths",
                Designation = "HOD-Maths",
                Experience = 14
            };

            //lecturers of mathematics directly reports to HOD-Maths
            hodMathematic.AddEmployee(mathTeacher1);
            hodMathematic.AddEmployee(mathTeacher2);

            #endregion

            #region Computer Science departments

            //3 lecturers work in Computer Science department
            Employee csTeacher1 = new Employee()
            {
                Name = "C. Sam",
                Dept = "Computer Science",
                Designation = "Lecturer",
                Experience = 10.2
            };
            Employee csTeacher2 = new Employee()
            {
                Name = "C. Jones",
                Dept = "Computer Science",
                Designation = "Lecturer",
                Experience = 13.5
            };
            Employee csTeacher3 = new Employee()
            {
                Name = "C. Marium",
                Dept = "Computer Science",
                Designation = "Lecturer",
                Experience = 7.3
            };

            //the college has a Head of Department in Computer Science
            CompositeEmployee hodComputerScience = new CompositeEmployee()
            {
                Name = "Mr. V.Sarcar",
                Dept = "Computer Science",
                Designation = "HOD-CS",
                Experience = 16.5
            };

            //lecturers of Computer Science directly report to HOD-CS
            hodComputerScience.AddEmployee(csTeacher1);
            hodComputerScience.AddEmployee(csTeacher2);
            hodComputerScience.AddEmployee(csTeacher3);

            #endregion

            #region Top level management

            //the collage also has a Principal
            CompositeEmployee principal = new CompositeEmployee()
            {
                Name = "Dr. S.Som",
                Dept = "Planning-Supervising-Managing",
                Designation = "Principal",
                Experience = 21
            };

            //hods of Maths and CS directly report to Principal
            principal.AddEmployee(hodMathematic);
            principal.AddEmployee(hodComputerScience);

            #endregion

            //printing the leaf-nodes and branches in the same way
            //in each case we are calling DisplayDetails() method

            Console.WriteLine("Details of a Principal object is as follows:");
            //prints the complete structure
            principal.DisplayDetails();

            Console.WriteLine("Details of a HOD object is as follows:");
            //print details of Computer Science department
            hodComputerScience.DisplayDetails();

            //leaf node
            Console.WriteLine("Details of an individual employee (leaf node) is as follows:");
            mathTeacher1.DisplayDetails();

            //suppose, one Computer Science lecturer (C. Jones) is leaving now from the organization

            hodComputerScience.RemoveEmployee(csTeacher2);

            Console.WriteLine("After the resignation of C. Jones, the organization has the following members:");
            principal.DisplayDetails();

            List<IEmployee> participants = new List<IEmployee>();
            //for employees who directly reports to Principal

            foreach (IEmployee employee in principal.subordinateList)
            {
                participants.Add(employee);
            }

            //for employees who directly reports to HOD-Maths
            foreach (IEmployee employee in hodMathematic.subordinateList)
            {
                participants.Add(employee);
            }

            //for employees who directly reports to HOD-CS
            foreach (IEmployee employee in hodComputerScience.subordinateList)
            {
                participants.Add(employee);
            }

            Console.WriteLine("Visitor starts visiting our composite structure.");
            VisitorWithCompositePattern.IVisitor visitor = new PromotionCheckerVisitor();

            //principal is already holding the highest position
            //we are not checking if he is eligible or not

            foreach (IEmployee employee in participants)
            {
                employee.Accept(visitor);
            }

            #endregion

            Console.Read();
        }
    }
}
