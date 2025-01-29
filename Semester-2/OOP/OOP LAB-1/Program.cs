using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float lenght;
            float area;
            string input;
            Console.WriteLine("Enter the lenght of one side of square ");
            input = Console.ReadLine();
            lenght = float.Parse(input);
            area = lenght * lenght ;
            Console.WriteLine(area);
            Console.ReadLine();
        }
    }
}
