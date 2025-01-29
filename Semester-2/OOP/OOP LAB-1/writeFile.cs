using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    internal class writeFile
    {
        static void Main(string[] args) 
        {
            string path = "C:\\Users\\Hamza Jamil\\Desktop\\New Text Document.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine("Hello World !");
            file.Flush();
            file.Close();
        }
    }
}
