using System;
using System.Collections.Generic;
using System.Text;

namespace Week4Day1
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public int Age => DateTime.Now.Year - BirthYear;

        public Person(string firstName, string lastName, int birthYear)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
        }
    }
}
