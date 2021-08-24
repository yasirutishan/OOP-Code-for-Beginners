using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Child child1 = new Child();
            child1.sayHi();
        }
        class Parent
        {
            public void sayHi()
            {
                Console.WriteLine("Hi..Hi..");
            }
            public void sayBye()
            {
                Console.WriteLine("Bye..Bye");
            }
        }

        class Child : Parent
        {
            public void sayWhat()
            {
                Console.WriteLine("What..");
            }
        }
    }
}
