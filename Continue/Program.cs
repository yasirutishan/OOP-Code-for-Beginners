using System;

namespace Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            while (a < 5)
            {
                a++;
                Console.WriteLine(a);
                if (a == 3)
                {
                    continue;
                }
                Console.WriteLine("lol");
            }
        }
    }
}
