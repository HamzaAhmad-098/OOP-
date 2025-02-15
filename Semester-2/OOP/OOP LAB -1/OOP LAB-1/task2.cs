using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    internal class task2
    {
        static void Main(string[] args) 
        {
            string input;
            float marks;
            Console.WriteLine("Enter your marks :");
            input = Console.ReadLine();
            marks = float.Parse(input);
            if (marks > 50)
            {
                Console.WriteLine("you are passed");
            }
            else
            {
                Console.WriteLine("you are failed");
            }
            Console.WriteLine();
        }
    }
}
