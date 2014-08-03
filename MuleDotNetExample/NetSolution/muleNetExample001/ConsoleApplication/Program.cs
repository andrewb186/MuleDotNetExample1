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
            PersonInterface getPerson = new PersonInterface();
            Person person = getPerson.GetPerson(1);
            
            Console.WriteLine("Method :: GetByID :: {0} ", (person.ID == 1));            
        }

        static void TestInsertPerson(string name, string surname, string username, string password)
        {
            PersonInterface insertPerson = new PersonInterface();
            int _id = insertPerson.InsertPerson(name, surname, username, password);

            Console.WriteLine("Method :: InsertPerson(String, String, String, String) :: {0} ", ( _id > 0));            
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


            PersonInterface insertPerson = new PersonInterface();
            int id = insertPerson.InsertPerson(p);

            Console.WriteLine("Method :: InsertPerson(Person) :: {0} ", (id > 0));
        }

        static void TestGetAll()
        {
            PersonInterface getAll = new PersonInterface();
            List<Person> list = getAll.GetPersons();

            Console.WriteLine("Method :: GetPersons() :: {0} ", (list.Count > 0));
        }

    }
}
