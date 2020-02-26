using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoShop.Classes
{
    class Users
    {
        private string userName;
        private string userPass;
        private string userEmail;
        private int userCountryID;
        public Users(string name, string pass, string email, int countryID)
        {
            userName = name;
            userPass = pass;
            userEmail = email;
            userCountryID = countryID;
        }
    }
}
