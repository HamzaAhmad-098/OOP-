using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    internal class LoginMenu
    {
        static string signIn(string name, string password, string[,] arr)
        {
            if (!File.Exists("D:\\Semester-2\\OOP\\OOP LAB\\signIn.txt"))
            {
                return "File not found!";
            }
            StreamReader file = new StreamReader("D:\\Semester-2\\OOP\\OOP LAB\\signIn.txt");
            string line;
            string text = "";
            int x = 0;
            while ((line = file.ReadLine()) != null)
            {
                int a = 0;
                text = "";
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == ',')
                    {
                        arr[x, a] = text;
                        a++;
                        text = "";
                    }
                    else
                    {
                        text += line[i]; 
                    }
                }
                arr[x, a] = text;
                x++;
            }
            file.Close();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i, 0] == name && arr[i, 1] == password)
                {
                    return "Login successful!";
                }
            }
            return "Invalid username or password.";
        }
        static string signUp(string name, string password)
        {
            StreamWriter file = new StreamWriter("D:\\Semester-2\\OOP\\OOP LAB\\signIn.txt", true);
            file.WriteLine(name + "," + password);
            file.Close();
            return "Sign up successful.";
        }
        static int Menu()
        {
            int option;
            Console.WriteLine("1. Sign In ");
            Console.WriteLine("2. Sign Up ");
            Console.WriteLine("3. Exit ");
            Console.WriteLine("Your option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        static void Main(string[] args)
        {
            string[,] arr = new string[100, 2];

            while (true)
            {
                int option = Menu();
                if (option == 1)
                {
                    string name, password;
                    Console.WriteLine("Enter your name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter your password: ");
                    password = Console.ReadLine();
                    string result = signIn(name, password, arr);
                    Console.WriteLine(result);
                }
                if (option == 2)
                {
                    string name, password;
                    Console.WriteLine("Enter your user name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter your password: ");
                    password = Console.ReadLine();
                    Console.WriteLine(signUp(name, password));
                }
                if (option == 3)
                {
                    break; 
                }
            }
        }
    }
}
