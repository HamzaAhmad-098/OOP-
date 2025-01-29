using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    internal class conditional
    {
        static void Main(string[] args) 
        {
            string str;
            float input =0;
            float sum = 0;
            while (input != -1)
            {
                sum += input;
                str = Console.ReadLine();
                input = float.Parse(str);
                
            }
            Console.WriteLine("The sum is {0}",sum);
            Console.ReadLine();
        }
    }
}
