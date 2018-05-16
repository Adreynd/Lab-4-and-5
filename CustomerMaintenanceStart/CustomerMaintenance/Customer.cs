using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenance
{
    class Customer
    {
        private string firstName;
        private string lastName;
        private string email;

        Customer() { }

        Customer(string fn, string ln, string e)
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
    }
}
