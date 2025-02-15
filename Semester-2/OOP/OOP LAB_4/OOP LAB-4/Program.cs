using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.name = "Hamza";
            student1.rollNumber = 1;
            student1.matricMarks = 1049;
            student1.fscMarks = 1079;
            student1.homeTown = "Kasur";
            student1.cgpa = 3.5f;
            student1.ecatMarks = 304;
            student1.isHostelite = true;
            int ch = 0;
            while (true)
            {
                Console.WriteLine("1.calculate merit ");
                Console.WriteLine("2.is eligible for scholarship");
                Console.WriteLine("3.exit");
                ch = int.Parse(Console.ReadLine());
                if (ch == 1)
                {
                    Console.WriteLine("Merit is : " + student1.claculateMerit());
                }
                else if (ch == 2)
                {
                    float merit = student1.claculateMerit();
                    Console.WriteLine("Student is eligible for scholarship " + student1.isEligibleforScholarship(merit));
                }
                else if (ch == 3) 
                {
                    break;
                }
            }
        }
    }
}
