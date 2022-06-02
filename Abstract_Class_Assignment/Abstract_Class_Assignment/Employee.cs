using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Assignment
{
    class Employee : Person
    {
        public int ID { get; set; }
        public void SayName(string firstName, string lastName)
        {
            Console.WriteLine(firstName + " " + lastName);

        }
    }
}
