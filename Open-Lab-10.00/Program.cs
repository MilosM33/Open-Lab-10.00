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
            LOTR.Author = "Jano";
            LOTR.Pages = 256;
            LOTR.Category = "Ucebnica";
            LOTR.Title = "Elektrika";
            LOTR.ReleaseDate = 2020;

            Console.WriteLine(LOTR.Title);
            Console.WriteLine(LOTR.Author);
            Console.WriteLine(LOTR.Pages);
            Console.WriteLine(LOTR.Category);
            Console.WriteLine(LOTR.ReleaseDate);
        }
    }
    class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;
        public string Title
        {
            get => title;
            set => title = value;
        }
        public int Pages
        {
            get => pages;
            set => pages = (value < 0 ? -1 : value);
        }
        public string Category
        {
            get => category;
            set => category = value;
        }
        
        public string Author
        {
            get => author;
            set => author = value;
        }
        public int ReleaseDate
        {
            get => releaseDate;
            set => releaseDate = (value < 1450 || value > 2021 ? -1 : value);
        }
        public void SetTitle(string title) => this.title = title;

        public void SetNumberOfPages(int pages) => this.pages = pages;

        public void SetCategory(string category) => this.category = category;

        public void SetAuthor(string author) => this.author = author;
        
        public void SetReleaseDate(int releaseDate) => this.releaseDate = releaseDate;

        public void GetInfo() => Console.WriteLine($"{title} is very original book long about {pages} by {author} released at {releaseDate}. Category = {category}");
        
    }
}
