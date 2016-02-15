using ContactDBHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test
{
    class Contact
    {
        private List<Person> contacts;

        public List<Person> Contacts { get { return contacts; } set { contacts = value; } }

        public Contact()
        {
            contacts = new List<Person>();
            //contacts.Add(new Person("Mattias", "Hagelin", "8508210000"));
            //contacts.Add(new Person("Matilda", "Haag", "8208020000"));
            //contacts.Add(new Person("Jennie", "Hagelin", "8312050000"));
            //contacts.Add(new Person("Markus", "Svensson", "7503060000"));
            //contacts.Add(new Person("Jerker", "Stenmundsson", "6001050000"));
            //contacts.Add(new Person("Jens", "Carlsson", "9006080000"));
            //contacts.Add(new Person("Mats", "Sundin", "6405210000"));
            //contacts.Add(new Person("Findus", "Kattsson", "6607010000"));
            //contacts.Add(new Person("Fredrik", "Ljung", "7309250000"));
            //contacts.Add(new Person("Kerstin", "Olsson", "5504300000"));
            //contacts.Add(new Person("Nicklas", "Danielsson", "6911010000"));
            //contacts.Add(new Person("Nils", "Holgersson", "2002280000"));
            //contacts.Add(new Person("Barak", "Bear", "9906030000"));
        }

    }
}