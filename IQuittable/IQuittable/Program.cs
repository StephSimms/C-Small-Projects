using System;

namespace Interface_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.firstName = "Sample";
            employee.lastName = "Student";

            employee.SayName(employee.firstName, employee.lastName);

            Console.ReadLine();
        }
    }
}
