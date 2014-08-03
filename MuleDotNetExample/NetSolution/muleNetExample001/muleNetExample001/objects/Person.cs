using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace muleNetExample001.objects
{
    public class Person
    {
        private int _ID;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private String _Name;
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private String _Surname;
        public String Surname
        {
            get { return _Surname; }
            set { _Surname = value; }
        }


        private int? _Age;
        public int? Age
        {
            get { return _Age; }
            set { _Age = value; }
        }

        private String _Telephone;
        public String Telephone
        {
            get { return _Telephone; }
            set { _Telephone = value; }
        }

        private String _Email;
        public String Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private Credentials _Credential;
        public Credentials Credential
        {
            get { return _Credential; }
            set { _Credential = value; }
        }
        

        public Person() 
        {
            _Credential = new Credentials();
        }

        
    }
}
