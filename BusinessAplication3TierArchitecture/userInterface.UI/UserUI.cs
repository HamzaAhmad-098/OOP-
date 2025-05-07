using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAplication3TierArchitecture.userInterface.UI
{
    internal class UserUI
    {
        public int userMenu()
        {
            Console.Clear();

            int choice;
            Console.WriteLine("$$   USER MENU   $$");
            Console.WriteLine("1.Check stations list");
            Console.WriteLine("2.Get ticket online");
            Console.WriteLine("3.send feed back");
            Console.WriteLine("4.SEE for discount ");
            Console.WriteLine("5.Exit");
            Console.WriteLine("your choice ");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public int mainMenu()
        {
            Console.Clear();

            int choice;
            Console.WriteLine("1.Admin login");
            Console.WriteLine("2.User login");
            Console.WriteLine("3.Exit");
            Console.WriteLine("Your choice");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
