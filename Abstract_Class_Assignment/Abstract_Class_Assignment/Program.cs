using System;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.fName = "Sample";
            person.lName = "Sample Sample";

            person.SayName(person.fName, person.lName);

            Console.ReadLine();

        }
    }
}
