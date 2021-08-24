using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            
            switch (a)
            {
                case 0: Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("other");
                    break;
            }
        }
    }
}
