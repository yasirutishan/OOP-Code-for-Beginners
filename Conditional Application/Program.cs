using System;

namespace Conditional_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            string result = "none";

            /*if(a < b)
            {
                result = "A";
            }
            else
            {
                result = "Z";
            }*/

            result = (a < b) ? "A" : "Z";

            Console.WriteLine(result);
        }
    }
}
