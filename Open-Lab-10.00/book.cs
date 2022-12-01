using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    internal class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;
        


        public string GetTitle()
        {
            return this.title;
        }
        public string SetTitle(string title)
        {
            this.title = title;
            return title;
        }
        public int GetPages(int pages)
        {
            return this.pages;
        }
        public int SetPages(int pages)
        {
            this.pages = pages;
            return pages;
        }
        public string GetCategory(string category)
        {
            return this.category;
        }
        public string SetCategory(string category)
        {
            this.category = category;
            return category;
        }
        public string GetAuthor(string author)
        {
            return this.author;
        }
        public string SetAuthor(string author)
        {
            this.author = author;
            return author;
        }

        public int GetReleaseDate(int releaseDate)
        {
            return this.releaseDate;
        }
        public int SetReleaseDate(int releaseDate)
        {
            this.releaseDate = releaseDate;
            return releaseDate;
        }

        public void WriteAll()
        {
            Console.Write($"{title}\n{pages}\n{category}\n{author}\n{releaseDate}\n");
        }
    }
}
