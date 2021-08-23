using System;

namespace If_Statement___2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            if (a == b)// if the condition ture then run the block
            {
                Console.WriteLine("a equal b");
            }
            else if (a > b) 
            {
                Console.WriteLine("a greater than b");
            }
            else
            {
                Console.WriteLine("none");
            }
        }
    }
}
