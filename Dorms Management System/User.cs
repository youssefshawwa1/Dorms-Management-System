using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorms_Management_System
{
    public class User
    {
        private int userId;
        private string username;
        private string password;
        private string userType;

        public User(int userID, string username, string password, string userType)
        {
           this.userId = userID;
            this.username = username;
            this.password = password;
            this.userType = userType;
        }
        public int UserID
        {
            get { return this.userId; }
            set { this.userId = value; }
        }
        public string UserName
        {
            get { return this.username; }
            set { this.username = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public string UserType
        {
            get { return this.userType; }
            set{ this.userType = value; }
        }

    }
}
