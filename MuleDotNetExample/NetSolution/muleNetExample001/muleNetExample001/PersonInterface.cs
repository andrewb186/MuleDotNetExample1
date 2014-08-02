using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using muleNetExample001.objects;
using muleNetExample001.dbml;


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
            person.Age = personInfo.age;

            person.Credential.Username = personInfo.Credential.username;
            person.Credential.Password = personInfo.Credential.password;

            return person;
        }


    }
}
