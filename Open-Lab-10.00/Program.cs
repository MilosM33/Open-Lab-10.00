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
            LOTR.SetAuthor("Jano");
            LOTR.SetNumberOfPages(256);
            LOTR.SetCategory("Action");
            LOTR.SetTitle("Elektrika");
            LOTR.SetCategory("Učebnica");
            LOTR.SetReleaseDate(2020);
            LOTR.GetInfo();
            
        }
    }
    class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;

        public void SetTitle(string title) => this.title = title;

        public void SetNumberOfPages(int pages) => this.pages = pages;

        public void SetCategory(string category) => this.category = category;

        public void SetAuthor(string author) => this.author = author;
        
        public void SetReleaseDate(int releaseDate) => this.releaseDate = releaseDate;

        public void GetInfo() => Console.WriteLine($"{title} is very original book long about {pages} by {author} released at {releaseDate}. Category = {category}");
        
    }
}
