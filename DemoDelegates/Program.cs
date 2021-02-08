using System;

namespace DemoDelegates
{
    class Program
    {


        static void MyMethod()
        {
            Console.WriteLine("HelloWorld!");
        }
        public static void Main(string[] args)
        {
            // Tilldela variabeln a av typen Action metoden MyMethod.
            Action a = MyMethod;
            // Anropa metoden som variabeln a tilldelats.
            a();
        }
    }
}


