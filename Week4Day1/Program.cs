using System;
using System.Collections.Generic;
using System.Linq;

namespace Week4Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            var historicSwedes = new List<Person>();
            historicSwedes.Add(new Person("Ellen", "Key", 1849));
            historicSwedes.Add(new Person("Lars", "Norén", 1944));
            historicSwedes.Add(new Person("Eva", "Ekeblad", 1724));
            historicSwedes.Add(new Person("Ingmar", "Bergman", 1918));
            historicSwedes.Add(new Person("Elin", "Wägner", 1882));
            historicSwedes.Add(new Person("August", "Strindberg", 1849));
            historicSwedes.Add(new Person("Gustav", "Wasa", 1496));
            historicSwedes.Add(new Person("Fredrika", "Bremer", 1801));
            historicSwedes.Add(new Person("Alfred", "Nobel", 1833));
            historicSwedes.Add(new Person("Inga-Britt", "Ahlenius", 1939));


            FilteredListOfPeople(historicSwedes);

            var sumOfAge = historicSwedes
                .Where(p => p.BirthYear >= 1900)
                .Sum(p => p.Age);

            Console.WriteLine(sumOfAge);
        }
        

        static void FilteredListOfPeople(List<Person> people)
        {
            List<Person> temp = new List<Person>();
            foreach (var item in people)
            {
                if (item.BirthYear >= 1900)
                {
                    Console.WriteLine(item.FirstName);
                }
            }
        }


    }
}
