using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using muleNetExample001;
using muleNetExample001.objects;

namespace ConsoleApplication
{
    class Program
    {
        static PersonInterface personInterface = new PersonInterface();

        static void Main(string[] args)
        {
            TestGetByID();
            TestInsertPerson("Chris", "Griffin", "cgriffin", "cgriffin12");
            TestInsertPerson();
            TestGetAll();

            Console.ReadLine();
        }


        static void TestGetByID()
        {
            Person person = personInterface.GetPerson(0);
            Console.WriteLine("Method :: GetByID :: {0} ", (person.ID == 0));            
        }

        static void TestInsertPerson(string name, string surname, string username, string password)
        {
            int _id = personInterface.InsertPerson(name, surname, username, password);
            Console.WriteLine("Method :: InsertPerson(String, String, String, String) :: {0} ", (_id > 0));            
        }

        static void TestInsertPerson()
        {
            Person p = new Person();
            p.Name = "Stewie";
            p.Surname = "Griffin";
            p.Age = 3;
            p.Email = "sgriffin";

            p.Credential.Password = "stewie";
            p.Credential.Username = "sgriffin";

            int id = personInterface.InsertPerson(p);

            Console.WriteLine("Method :: InsertPerson(Person) :: {0} ", (id > 0));
        }

        static void TestGetAll()
        {
            List<Person> list = personInterface.GetPersons();
            Console.WriteLine("Method :: GetPersons() :: {0} ", (list.Count > 0));
        }

    }
}
