using System;

namespace Delegater02
{
    class Program
    {
        static void PrintIt(string s, bool b)
        {
            if (b)
            {
                Console.WriteLine(s.ToUpper());
            }
            else
                Console.WriteLine(s.ToLower());
        }
        static void Main(string[] args)
        {
            Action<string, bool> phrase = PrintIt;
            phrase("Hello World", true);
            phrase("Hello World", false);

        }
    }
}
