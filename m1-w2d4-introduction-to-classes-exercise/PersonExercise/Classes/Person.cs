using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Person
    {
        // class members
        public string firstName;
        public string lastName;
        public int age;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public bool IsAdult()
        {
            if (age >= 18)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
