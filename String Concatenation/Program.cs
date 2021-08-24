using System;

namespace String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "smith ";
            string lname = "bond";
            string fullname = $"{fname}{lname}";
            Console.WriteLine(fname+lname);
            Console.WriteLine(string.Concat (fname,lname));
            Console.WriteLine(fullname);
        }

    }
}
