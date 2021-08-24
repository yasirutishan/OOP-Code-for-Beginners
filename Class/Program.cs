using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)

        {
            Book book1 = new Book();
            book1.title = "book1 title";
            book1.pages = 10;

            Book book2 = new Book();
            book2.title = "book2 title";
            book1.pages = 20;
        }
    }

    class Book
    {
        public string title;
        public int pages;
    }
}
