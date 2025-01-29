using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    internal class doWhile
    {
        static void Main(string[] args) 
        {
            string str;
            float input = 0;
            float sum = 0;
            do
            {
                sum += input;
                str = Console.ReadLine();
                input = float.Parse(str);
                
            }
            while (input != -1) ;
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
