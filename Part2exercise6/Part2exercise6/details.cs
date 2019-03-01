using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2exercise6
{
    class details
    {
        private string first_name;
        private string last_name;
        private string username;
        private string password;

        public string First_Name
        {
            get { return this.first_name; }
            set { this.first_name = value; }
        }

        public string Last_Name
        {
            get { return this.last_name; }
            set { this.last_name = value; }
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
    }
}
