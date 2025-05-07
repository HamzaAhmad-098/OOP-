using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAplication3TierArchitecture.businessLayer.bl
{
    internal class tickets
    {
        public void GetTicket(int price, int payAmount, string mode, string startingStation, string endingStation)
        {
            Console.Clear();

            int remaining = payAmount - price;
            Console.WriteLine("           SVC receipt                 			                ");
            Console.WriteLine("------------------------------------------       ");
            Console.WriteLine(" Ticket type : Normal stored value tocken  	                ");
            Console.WriteLine($"	Mode of payment  :  {mode}");
            Console.WriteLine($"	Pay amount is :   {payAmount}");
            Console.WriteLine($"	Price is :    {price} ");
            Console.WriteLine($"	Remaining Fare Value : {remaining} ");
            Console.WriteLine($"	Current Station  :    {startingStation}");
            Console.WriteLine($"	Token is from {startingStation}  to {endingStation}");
            Console.WriteLine("	please check the receipt");
            Console.WriteLine("Press any key to proceed....");
            Console.ReadKey();
        }
        public int CheckDiscount()
        {
            int choice;
            Console.WriteLine("1. you are student! ");
            Console.WriteLine("2. you are special person ! ");
            Console.WriteLine("Enter your choice ");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public void studentTicket(string name, string institute, string startingStation, string endingStation)
        {
            Console.Clear();

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("           SVC receipt                 			                ");
            Console.WriteLine("------------------------------------------       ");
            Console.WriteLine(" Ticket type : Student Type value tocken  	                ");
            Console.WriteLine($"	Student Name  : {name}");
            Console.WriteLine($"	Institute Name :  {institute} ");
            Console.WriteLine($"	Price is :   0 ");
            Console.WriteLine($"	Current Station  :  {startingStation}  ");
            Console.WriteLine($"Token is from {startingStation}  to {endingStation}");
            Console.WriteLine("	please check the receipt");
            Console.WriteLine("Press any key to proceed....");
            Console.ReadKey();
        }
        public void specialPersonTicket(string name, string fault, string startingStation, string endingStation)
        {
            Console.Clear();

            Console.WriteLine("---------------------------------");
            Console.WriteLine("           SVC receipt                 			                ");
            Console.WriteLine("------------------------------------------       ");
            Console.WriteLine(" Ticket type : Special Person value tocken  	                ");
            Console.WriteLine($"	Person Name  : {name}");
            Console.WriteLine($"	Disability  :  {fault} ");
            Console.WriteLine("  	Price is :    0");
            Console.WriteLine($"	Current Station  :    {startingStation}");
            Console.WriteLine($"	Token is from  {startingStation} to  {endingStation}");
            Console.WriteLine("	please check the receipt");
            Console.WriteLine("Press any key to proceed....");
            Console.ReadKey();
        }
        public int price(int start, int end)
        {
            int stationsToTravel = Math.Abs(end - start);
            int ticketPrice = 25 + (stationsToTravel - 1) * 5;
            if (ticketPrice > 45)
            {
                ticketPrice = 45;
            }

            return ticketPrice;
        }
    }
}
