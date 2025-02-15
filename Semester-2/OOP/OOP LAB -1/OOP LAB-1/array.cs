using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OOP_LAB
{
    internal class array
    {
        static void Main(string[] args) 
        {
            int[] numbers = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the number {0} :",i);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int largest = -1;
            int x= 0;
            while (x != 3)
            {
                if (numbers[x] > largest)
                { 
                    largest = numbers[x ];
                }
                x++;
            }
            Console.WriteLine("Maximum Value is {0} ", largest);
            Console.ReadLine();
        }
    }
}
