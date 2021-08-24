using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.setTitle ("title1");
            Console.WriteLine(book1.getTitle());
        }
    }

    class Book
    {
        private string title;
        private int noofpages;

        public void setTitle(string t)
        {
            title = t;
        }

        public string getTitle()
        {
            return title;
        }

    }

}
