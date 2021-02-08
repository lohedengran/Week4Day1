using System;

namespace Delegater01
{
    class Program
    {
        static void Accelarate()
        {
            Console.WriteLine("Wroom...");
        }
        static void Decelerate()
        {
            Console.WriteLine("Screeech...");
        }
        static void Main(string[] args)
        {
            Action carAction = Accelarate;
            carAction();

            carAction = Decelerate;
            carAction();


        }
    }
}
