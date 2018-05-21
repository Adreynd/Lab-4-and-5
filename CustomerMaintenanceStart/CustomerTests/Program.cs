using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerMaintenanceClasses;

namespace CustomerTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCustomerConstructors();
            TestCustomerGetters();
            TestCustomerSetters();
            TestCustomerToString();

            Console.WriteLine();
            Console.ReadLine();
        }

        static void TestCustomerConstructors()
        {
            Customer c1 = new Customer();
            Customer c2 = new Customer("Nohm", "Chomskey", "nohm@chomskey.com");

            Console.WriteLine("Testing both constructors");
            Console.WriteLine("Default constructor.  Expecting default values. " + c1.GetDisplayText());
            Console.WriteLine("Overloaded constructor.  Expecting Nohm Chomskey, nohmchomskey.com. ");
            Console.WriteLine("Getting " + c2.GetDisplayText());
            Console.WriteLine();
        }

        static void TestCustomerGetters()
        {
            Customer c1 = new Customer("Nohm", "Chomskey", "nohm@chomskey.com");

            Console.WriteLine("Testing getters");
            Console.WriteLine("First name.  Expecting Nohm. " + c1.FirstName);
            Console.WriteLine("Last name.  Expecting Chomskey. " + c1.LastName);
            Console.WriteLine("Email.  Expecting nohm@chomskey.com. " + c1.Email);
            Console.WriteLine();
        }

        static void TestCustomerSetters()
        {
            Customer c1 = new Customer("Nohm", "Chomskey", "nohm@chomskey.com");

            Console.WriteLine("Testing setters");
            c1.FirstName = "Kyle";
            c1.LastName = "Normand";
            c1.Email = "kyle@normand.com";
            Console.WriteLine("Expecting Kyle, Normand, kyle@normand.com.");
            Console.WriteLine("Getting " + c1.GetDisplayText());
            Console.WriteLine();
        }
        static void TestCustomerToString()
        {
            Customer c1 = new Customer("Nohm", "Chomskey", "nohm@chomskey.com");

            Console.WriteLine("Testing ToString");
            Console.WriteLine("Expecting Nohm, Chomskey, nohm@chomskey.com. " + c1.GetDisplayText());
            Console.WriteLine("Getting Nohm, Chomskey, nohm@chomskey.com. " + c1.ToString());
            Console.WriteLine();
        }
    }
}
