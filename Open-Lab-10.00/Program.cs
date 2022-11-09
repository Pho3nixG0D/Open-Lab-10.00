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
            LOTR.title = "The Lord of the Rings";
           // LOTR.Pages = 1178;
            Console.WriteLine(LOTR.title);
        }
    }
}
