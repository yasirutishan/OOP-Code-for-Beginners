using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "book1 title";
            book1.pages = 10;

            Book book2 = new Book("book2",5);
            Console.WriteLine(book2.title);
            Console.WriteLine(book2.pages);
        }
    }

    class Book
    {
        public string title;
        public int pages;

        public Book()
        {

        }

        public Book(String t,int p)

        {
            title = t;
            pages = p;
        }
    }
}
