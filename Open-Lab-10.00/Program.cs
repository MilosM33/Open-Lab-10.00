using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.title = "Elektrika";
            Console.WriteLine(LOTR.title);
        }
    }
    class Book
    {
        public string title;
        private int pages;
    }
}
