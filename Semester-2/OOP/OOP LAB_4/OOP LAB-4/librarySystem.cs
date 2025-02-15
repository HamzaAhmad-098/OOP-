using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_4
{
    internal class librarySystem
    {
        static void Main(string[] args)
        {
            List <string> chapters = new List<string>() { "bsdfhew","hbvferi","sdbugfreiu","jkerguie","cbweygf","udwygfewy","vweyu"};
            Book book1 = new Book ("ABC","ALi",45,20,1100,true,chapters);
            int ch , chNo;
            while (true)
            {
                Console.WriteLine("1.IsBookAvailable");
                Console.WriteLine("2.GetChapters");
                Console.WriteLine("3.GetBookMark");
                Console.WriteLine("Exit");
                ch = int.Parse(Console.ReadLine());
                if (ch == 1)
                {
                    Console.WriteLine("Book Available : " + book1.isBookAvailable());
                }
                else if (ch == 2)
                {
                    Console.WriteLine("Enter the chapter name");
                    chNo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Chapter No " + chNo + " is " + book1.getChapter(chNo));
                }
                else if (ch == 3)
                {
                    Console.WriteLine("Book Mark is : "+book1.getBookMark());
                }
                else if (ch == 4)
                {
                    break;
                }
            }
        }
    }
}
