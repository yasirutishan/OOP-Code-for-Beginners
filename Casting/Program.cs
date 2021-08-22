using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = 45.9;

            double c = a;
            Console.WriteLine(c);
            int d = (int)b;
            Console.WriteLine(d);
            Console.WriteLine(b);



        }
    }
}
