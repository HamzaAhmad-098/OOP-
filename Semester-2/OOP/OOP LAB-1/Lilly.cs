using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    internal class Lilly
    {
        static void Main(string[] args) 
        {
            int age;
            float X;//price of washing machine 
            float P;// price of unit toy 
            Console.WriteLine("Enter the age of lilly");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of Washing machine ");
            X = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of unit toy ");
            P = float.Parse(Console.ReadLine());
            float  amount = 0f;
            int a = 1;
            for (int i = 1; i <= age; i++) 
            {
                if(i%2 == 0) 
                {
                    amount += 10*a;
                    amount--;
                    a++;
                }
                else
                {
                    amount += P;
                }
            }
            if (amount > X)
            {
                Console.WriteLine(" YES! {0}", amount - X);
            }
            else 
            {
                Console.WriteLine("No {0}",amount - X);
            }
            Console.ReadLine();
        }
    }
}
