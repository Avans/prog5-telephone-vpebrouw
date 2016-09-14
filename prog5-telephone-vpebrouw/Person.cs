using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog5_telephone_vpebrouw
{
    class Person
    {
        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String PhoneNumber { get; set; }

        public String FullName { 
            get 
            { 
                return FirstName + " " + LastName; 
            }
        }

        public Person(String firstName, String lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            
            Random r = new Random(FullName.GetHashCode());
            StringBuilder sb = new StringBuilder("06");

            for (int i = 0; i < 8; i++)
                sb.Append(r.Next(0, 9));

            PhoneNumber = sb.ToString();
        }
    }
}
