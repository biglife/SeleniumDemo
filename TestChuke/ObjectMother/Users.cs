using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChuke.ObjectMother
{
    public class Users
    {
        public string UserName {get; set;}
        public string Password { get; set; }

        private Users(string username, string password) 
        {
            UserName = username;
            Password = password;
        }

        public static Users Admin()
        {
            return new Users("Sysadmin","abc123");
        }

    }
}
