using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Övn_3
{
    internal class PersonHandler
    {
        public void SetAge(Person pers, uint age)
        {
            pers.Age = age;
        }

        public void SetFirstName(Person pers, string fname) 
        { 
            pers.FirstName = fname; 
        }

        public void SetLastName(Person pers, string lname)
        {
            pers.LastName = lname;
        }

        public void SetHeight(Person pers, double height) 
        { 
            pers.Height = height; 
        }
        public void SetWeight(Person pers, double weight)
        {
            pers.Height = weight;
        }

        public Person CreatePerson(uint age, string fname, string lname, double height, double weight)
        {
            Person person = new Person();
            person.Age = age;
            person.FirstName = fname;
            person.LastName = lname;
            person.Height = height;
            person.Weight = weight;

            return person;
        }

    }
}
