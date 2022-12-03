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

            Console.WriteLine(LOTR.ToString());
        }
    }
}
