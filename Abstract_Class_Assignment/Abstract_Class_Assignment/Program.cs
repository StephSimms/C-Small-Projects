using System;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.fName = "Sample";
            employee.lName = "Student";

            employee.SayName(employee.fName, employee.lName);

            Console.ReadLine();

        }
    }
}
