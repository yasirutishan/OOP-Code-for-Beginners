using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            mymethod("Tishan");
            mymethod("Sinhara");
            mymethod("Yasiru");
        }
        static void mymethod(string para)
        {
            Console.WriteLine("Good Morning "+para);
        }

    }
}
