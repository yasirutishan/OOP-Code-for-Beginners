using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = { 1, 3, 5, 4 };

            Console.WriteLine(myarray[0]);

            myarray[1] = 9;

            Console.WriteLine(myarray[1]);

            string[] mystarray = new string[3];

            mystarray[0] = "one";
            mystarray[1] = "two";

        }
    }
}
