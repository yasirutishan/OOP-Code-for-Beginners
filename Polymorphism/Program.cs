using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        class Parent
        {
            public virtual void voice()
            {
                Console.WriteLine("loud voice");
            }
        }

        class child : Parent
        {

            public override void voice()
            {
                Console.WriteLine("soft voice");
            }

        }
    }
}
