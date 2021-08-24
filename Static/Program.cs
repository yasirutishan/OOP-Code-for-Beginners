using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "book1 title";
            book1.pages = 10;
            Book.sayHi();
        }
    }

    class Book
    {
        public string title;
        public int pages;
        public static string word = "Hi";


        public static void sayHi()
        {
            Console.WriteLine("Hi...Hi");
        }

    }
}

