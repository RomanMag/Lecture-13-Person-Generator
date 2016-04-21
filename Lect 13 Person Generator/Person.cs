using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect_13_Person_Generator
{
    public class Person : IPrintable
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string creationtime { get; set; }

        public void Print()
        {
            Console.WriteLine("Person: {0} {1}, creation time: {2}", name, surname, creationtime);
        }

        public Person(string PersonName, string PersonSurname)
        {
            name = PersonName;
            surname = PersonSurname;
            creationtime = "Unknown";
        }

        public Person(string PersonName, string PersonSurname, string TimeStamp)
            : this(PersonName, PersonSurname)
        {
            creationtime = TimeStamp;
        }

    }
}
