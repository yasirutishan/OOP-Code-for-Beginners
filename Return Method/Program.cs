using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getsum(4, 2));
        }


        static int getsum(int a, int b)
        {
            return a + b;
        }
      
    }
}
