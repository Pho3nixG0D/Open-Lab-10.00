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

            Console.WriteLine(LOTR.ToString());
            Console.WriteLine(LOTR2.ToString());
            Console.WriteLine(LOTR3.ToString());
            Console.WriteLine(HOBIT.ToString());
        }
    }
}
