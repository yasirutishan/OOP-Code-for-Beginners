using System;

namespace Logical_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine(a > b && a >= b);//false && false => false
            Console.WriteLine(a < b && a >= b);//ture && false => false
            Console.WriteLine(a > b && a <= b);//false && ture => fales
            Console.WriteLine(a < b && a != b);//ture && ture => ture

            Console.WriteLine(a > b || a >= b);//false && false => fales
            Console.WriteLine(a < b || a >= b);//ture && false => ture
            Console.WriteLine(a > b || a <= b);//false && ture => ture
            Console.WriteLine(a < b || a != b);//ture && ture => ture

            Console.WriteLine(a > b);//false 
            Console.WriteLine(a < b);//ture 

            Console.WriteLine(!(a > b ));//false =>ture
            Console.WriteLine(!(a < b));//ture =>false


        }
    }
}
