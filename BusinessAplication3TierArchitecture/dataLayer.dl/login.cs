using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAplication3TierArchitecture.dataLayer.dl
{
    internal class login
    {
        public static string[,] admin = new string[1, 2] { { "admin", "123" } };
        public static string[,] users = new string[100, 2];
        public string UserSignUp(string username, string password, ref int userCount)
        {

            users[userCount - 1, 0] = username;
            users[userCount - 1, 1] = password;
            userCount++;
            return "sign up successfully";
        }
    }
}   
