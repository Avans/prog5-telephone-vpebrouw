using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog5_telephone_vpebrouw
{
    class Program
    {
        static void Main(string[] args)
        {
            TelephoneBook telephoneBook = new TelephoneBook();

            Console.WriteLine("### Sorteren op achternaam ###");
            Show(telephoneBook.PersonsByLastName());

            String letter = "F";
            Console.WriteLine("### Firstname begint met '{0}' ###", letter);
            Show(telephoneBook.PersonsdByFirstLetter(letter));

            int minimumSize = 6;
            Console.WriteLine("### Lastname langer dan 5 ###", minimumSize);
            Show(telephoneBook.PersonsByLastNameLength(minimumSize));

            Console.WriteLine("### Sorteren op achternaam lengte ###");
            Show(telephoneBook.PersonsByLastNameLength());


            Console.ReadKey();
        }

        private static void Show(List<Person> list)
        {
            int i = 0;
            list.ForEach(p => Console.WriteLine("{0}. {1} - {2}", i++, p.FullName, p.PhoneNumber));
            Console.WriteLine("\n");
        }
    }
}
