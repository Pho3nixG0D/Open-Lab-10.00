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
            ///LOTR.title = "The Lord of the Rings";
            LOTR.SetTitle("The Lord of the Rings" );
            LOTR.SetPages(1178);
            LOTR.SetCategory("Heroic Romance");
            LOTR.SetAuthor("John Ronald Reuel Tolkien");
            LOTR.SetReleaseDate(1954);

            LOTR.WriteAll();
        }
    }
}
