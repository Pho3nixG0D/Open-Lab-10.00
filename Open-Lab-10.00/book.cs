using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
        /// <summary>
        /// This is List of book categories.
        /// </summary>
        public static List<string> categoryList = new List<string>() { "detské", "romantické", "náučné", "sci-fi", "dobrodružné" };
        public Book()
        {
            title = "-1";
            pages = -1;
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }
        public Book(string title, int pages)
        {
            this.title = title;
            this.pages = pages;
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }

        public Book(string title, int pages, string category, string author, int releaseDate)
        {
            this.title = title;
            this.pages = pages;
            this.category = category;
            this.author = author;
            this.releaseDate = releaseDate;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
  
        public int Pages
        {
            get { return pages; }
            set { if (value < 0) 
                { 
                    pages = 1; 
                } else
                {
                    pages = value;
                }
            }
        }

        public string Category
        {
            set { category = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

  
        public int ReleaseDate
        {
            get { return releaseDate; }
            set
            {
                if (1450 <= value || value <= 2021)
                {
                    releaseDate = value;
                }
                else
                {
                    releaseDate = -1;
                }
            }
        }

        public override string ToString()
        {
            return String.Format($"Title: {title}\nPages: {pages}\nCategory:{category}\nAuthor:{author}\nRelease Date:{releaseDate}\n");
        }
    }
}
