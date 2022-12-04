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
            Book LOTR = new Book();
            LOTR.Title = "The Lord of the Rings" ;
            LOTR.Pages = 1178;
            LOTR.Category = "Heroic Romance";
            LOTR.Author = "John Ronald Reuel Tolkien";
            LOTR.ReleaseDate = 1954;

            Book LOTR2 = new Book();
            Book LOTR3 = new Book( "Lord of The Rings 3" , 416);
            Book HOBIT = new Book("The Hobbit" , 304, "Fantasy novel", "John Ronald Reuel Tolkien", 1937);
            HOBIT.Category = Book.categoryList[4];

            Console.WriteLine($"{LOTR}\n{LOTR2}\n{LOTR3}\n{HOBIT}\n");

        }
    }
}
