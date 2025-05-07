using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAplication3TierArchitecture.userInterface.UI
{
    internal class AdminUI
    {
        public int adminMenu()
        {
            Console.Clear();

            int choice;
            Console.WriteLine("$$  ADMIN MENU  $$");
            Console.WriteLine("1.Adding station         ");
            Console.WriteLine("2.Removing station       ");
            Console.WriteLine("3.Read feedback 		    ");
            Console.WriteLine("4.changePasswordOrEmail  ");
            Console.WriteLine("5.Exit 					");
            Console.WriteLine("your choice...");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
