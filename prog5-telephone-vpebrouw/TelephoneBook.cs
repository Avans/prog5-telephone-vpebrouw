using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog5_telephone_vpebrouw
{
    class TelephoneBook
    {
        private List<Person> Persons;

        private int Size { 
            get 
            { 
                return Persons.Count; 
            }
        }

        public TelephoneBook()
        {
            Persons = new List<Person>() {
                new Person("Vincent3", "Brouwers1"),
                new Person("Vincent4", "Brouwers1"),
                new Person("Vincent5", "Brouwers1"),
                new Person("Vincent1", "Brouwers2"),
                new Person("Vincent1", "Brouwers3"),
                new Person("Vincent2", "Brouwers3"),
                new Person("Vincent1", "Brouwers4"),
                new Person("Vincent1", "Brouwers"),
                new Person("Fincent1", "Brouz"),
                new Person("Fincent2", "Brouz")
            };
        }

        public List<Person> PersonsByLastName()
        {
            return Persons.OrderBy(p => p.LastName).ToList();
        }

        public List<Person> PersonsdByFirstLetter(String letter)
        {
            return Persons.FindAll(p => p.FirstName.StartsWith(letter))
                .OrderBy(p => p.LastName).ToList();
        }

        public List<Person> PersonsByLastNameLength(int minimumLength)
        {
            return Persons.FindAll(p => p.LastName.Length >= minimumLength)
                .OrderBy(p => p.LastName.Length).ToList();
        }

        public List<Person> PersonsByLastNameLength()
        {
            return Persons.OrderBy(p => p.LastName.Length).ToList();
        }


    }
}
