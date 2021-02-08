using System;

namespace Delegater03
{
    class Program
    {
        public static bool IsLessThan(int first, int second)
        {
            return first < second;
        }
        static void Main(string[] args)
        {
            Func<int, int, bool> f = IsLessThan;
            bool x = f(10, 15);
            Console.WriteLine(x);
        }
    }
}
