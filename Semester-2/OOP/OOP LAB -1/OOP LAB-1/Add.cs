using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    internal class Add
    {
        static void Main(string[] args) 
        {
            int n1, n2;
            Console.WriteLine("Enter  first Number ");
            n1 = int.Parse(Console.ReadLine ());
            Console.WriteLine("Enter the second number ");
            n2 = int.Parse(Console.ReadLine ());
            Console.WriteLine("the sum of {0} and {1} is {2}", n1, n2, add(n1, n2));
            Console.ReadLine();
        }
        static int add(int x, int y)
        {
            return x + y;
        }
    }
}
