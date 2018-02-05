using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06_IntroOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person() { firstName = "Jonas", lastName = "Damsgaard", birthDate = 1984};
            Console.WriteLine(p1.Fullname());
            Console.WriteLine(p1.Age().ToString());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }

    class Person
    {
        public string firstName;
        public string lastName;
        public int birthDate;

        public Person()
        {
            firstName = "";
            lastName = "";
        }

        public Person(string firstName, string lastName, int birthDate)
        {
            this.firstName = firstName.ToUpper();
            this.lastName = lastName.ToUpper();
            this.birthDate = birthDate;
        }

        public string Fullname()
        {
            return firstName + " " + lastName;
        }

        public int Age()
        {
            return DateTime.Now.Year - birthDate;
        }
    }

}
