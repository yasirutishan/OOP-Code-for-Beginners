using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string name= ("Good Morning");
            Console.WriteLine(name);
            Console.WriteLine(name.Length);

            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());

            Console.WriteLine(name[0]);
            Console.WriteLine(name[11]);
            Console.WriteLine(name[7]);

            Console.WriteLine(name.IndexOf("M"));
            Console.WriteLine(name.IndexOf("o"));

            Console.WriteLine(name.Substring(5));
        }
    }
}
