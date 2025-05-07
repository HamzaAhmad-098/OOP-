using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAplication3TierArchitecture.businessLayer.bl
{
    internal class login
    {

        public bool AdminLogin(string username, string password)
        {
            if (username == dataLayer.dl.login.admin[0, 0] && password == dataLayer.dl.login.admin[0, 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string ChangeEmailPassword(int choice, string New)
        {
            if (choice == 1)
            {
                dataLayer.dl.login.admin[0, 0] = New;

            }
            else if (choice == 2)
            {
                dataLayer.dl.login.admin[0, 1] = New;

            }
            if (choice == 1)
            {
                return "Email changed successfully...";
            }
            else
            {
                return "Password changed successfully...";
            }

        }
        public bool UserSignIn(string username, string password, int userCount)
        {
            for (int i = 0; i < userCount; i++)
            {
                if (dataLayer.dl.login.users[i, 0] == username && dataLayer.dl.login.users[i, 1] == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
