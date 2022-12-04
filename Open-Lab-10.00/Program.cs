using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Objects
            Library schoolLibrary = new Library();
            Book Py = new Book("Python Zero to Hero",200, Book.categoryList[2],"M. Novak",2016);
            Book CSharp = new Book("All about C#", 389, Book.categoryList[2], "R. Popper", 2014);
            Book ComputerScience = new Book("Something about Computer Science", 89, Book.categoryList[2], "Unknown", 2000);
            Book Networks = new Book("Basics of networks", 126, Book.categoryList[2], "John N.", 2022);
            

            
            schoolLibrary.BooksList.Add(Py);
            schoolLibrary.BooksList.Add(CSharp);
            schoolLibrary.BooksList.Add(ComputerScience);
            schoolLibrary.BooksList.Add(Networks);


            schoolLibrary.StudentsList.Add("John");
            schoolLibrary.StudentsList.Add("Poul");

            schoolLibrary.NumberOfStudents = 2;
            schoolLibrary.NumberOfBooks = 4;

            Console.WriteLine(schoolLibrary.ToString());

        }
    }
}
