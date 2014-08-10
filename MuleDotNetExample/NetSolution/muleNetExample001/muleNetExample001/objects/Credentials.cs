using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace muleNetExample001.objects
{
    public class Credentials
    {
        private string _Username;
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }


        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }


        public Credentials(string username, string password)
        {
            _Username = username;
            _Password = password;
        }

        public Credentials()
        {
        }

    }
}
