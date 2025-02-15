using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    internal class fileRead
    {
        static void Main(string[] args) 
        {
            string path = "C:\\Users\\Hamza Jamil\\Desktop\\New Text Document.txt";
            if (File.Exists(path))
            {
                StreamReader file  = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                file.Close();
            }
            else 
            {
                Console.WriteLine("file not exists ");
            }
            Console.ReadLine();
        }
    }
}
