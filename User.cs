using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elib
{
    public class User
    {
        public int UserID { get; set; }
        public string Role { get; set; }
        public string Username { get; set; }

        public User(int userID, string role, string username)
        {
            UserID = userID;
            Role = role;
            Username = username;
        }
    }
}
