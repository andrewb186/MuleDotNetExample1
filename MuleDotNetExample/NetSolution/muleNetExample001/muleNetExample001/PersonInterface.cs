using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using muleNetExample001.objects;
using System.Data.Linq;

namespace muleNetExample001
{
    public class PersonInterface
    {
        private List<Person> persons;

        public PersonInterface()
        {
            persons = new List<Person>();

            Person p = new Person();
            p.ID = persons.Count;
            p.Name = "Peter";
            p.Surname = "Griffin";
            p.Email = "pgriffin@info.com";
            p.Credential.Password = "pass";
            p.Credential.Username = "username";

            persons.Add(p);
        }

        public Person GetPerson(int id)
        {
            Person personInfo = persons.Single<Person>(p => p.ID == id);
            return personInfo;
        }

        public int InsertPerson(Person person)
        {
            person.ID = persons.Count;
            persons.Add(person);
            return person.ID;
        }

        public int InsertPerson(string name, string surname, string username, string password)
        {
            Person p = new Person();

            p.ID = persons.Count;
            p.Name = name;
            p.Surname = surname;
            p.Credential.Password = password;
            p.Credential.Username = username;

            persons.Add(p);

            return p.ID;
        }
              

        public List<Person> GetPersons()
        {
            return persons;
        }


    }
}
