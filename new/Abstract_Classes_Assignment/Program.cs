using System;

namespace Abstract_Classes_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee();
            {
                newEmployee.firstName = "Sample";
                newEmployee.lastName = "Student";
                newEmployee.SayName();
            }

            Employee newEmployee2 = new Employee();
            {
                newEmployee2.firstName = "David";
                newEmployee2.lastName = "Happy";
                newEmployee2.SayName();
                //newEmployee2.Quit(string answer = "yes");
            }



        }
    }
}
