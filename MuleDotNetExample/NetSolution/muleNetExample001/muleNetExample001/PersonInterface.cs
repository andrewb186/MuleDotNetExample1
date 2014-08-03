using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using muleNetExample001.objects;
using muleNetExample001.dbml;
using System.Data.Linq;

namespace muleNetExample001
{
    public class PersonInterface
    {
        private PersonDataClassesDataContext dataContext;

        public PersonInterface()
        {
            dataContext = new PersonDataClassesDataContext();
        }

        public Person GetPerson(int id)
        {
            PersonDetail personInfo = dataContext.PersonDetails.Single(p => p.id == id);
                        
            Person person = new Person();
            person.ID = personInfo.id;
            person.Name = personInfo.name;
            person.Surname = personInfo.surname;
            person.Telephone = personInfo.telephone;
            person.Email = personInfo.email;
            person.Age = (int)personInfo.age;

            person.Credential.Username = personInfo.Credential.username;
            person.Credential.Password = personInfo.Credential.password;

            return person;
        }


        public int InsertPerson(string name, string surname, string username, string password)
        {
            PersonDetail personDetails = new PersonDetail();

            personDetails.name = name;
            personDetails.surname = surname;
           
            personDetails.Credential = new Credential();
            personDetails.Credential.username = username;
            personDetails.Credential.password = password;


            dataContext.PersonDetails.InsertOnSubmit(personDetails);
            dataContext.SubmitChanges();

            return personDetails.id;
        }


        public int InsertPerson(Person person)
        {
            PersonDetail personDetails = new PersonDetail();

            personDetails.name = person.Name;
            personDetails.surname = person.Surname;
            personDetails.age = person.Age;
            personDetails.email = person.Email;
            personDetails.telephone = person.Telephone;

            personDetails.Credential = new Credential();
            personDetails.Credential.username = person.Credential.Username;
            personDetails.Credential.password = person.Credential.Password;

            dataContext.PersonDetails.InsertOnSubmit(personDetails);
            dataContext.SubmitChanges();

            return personDetails.id;
        }

        public List<Person> GetPersons()
        {
            List<Person> persons = new List<Person>();


            var _persons = from p in dataContext.PersonDetails
                           join c in dataContext.Credentials on p.id equals c.personID
                           select new Person
                           {
                               ID = p.id,
                               Name = p.name,
                               Surname = p.surname,
                               Age = (int)p.age,
                               Telephone = p.telephone,
                               Email = p.email,

                               Credential = new Credentials { 
                                    Username = p.Credential.username,
                                    Password = p.Credential.password
                               }
                           };

            persons = _persons.ToList<Person>();

            return persons;
        }


    }
}
