using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenanceClasses
{
    public class Customer
    {
        private string firstName;
        private string lastName;
        private string email;

        public Customer()
        {
            firstName = "John";
            lastName = "Doe";
            email = "john@doe.com";
        }

        public Customer(string fn, string ln, string e)
        {
            firstName = fn;
            lastName = ln;
            email = e;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string GetDisplayText()
        {
            return firstName + " " + lastName + ", " + email + ".";
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " " + email;
        }
    }
}
