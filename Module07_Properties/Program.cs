using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.FirstName = "Jonas";
            p.LastName = "hhhhh";
            Console.WriteLine(p.FullName());

            var triangle = new Triangle();
            Console.WriteLine(triangle.Area.ToString());


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        public class Person
        {
            public string FirstName { get; set; }

            private string lastName;

            public string LastName
            {
                get { return lastName; }
                set
                {
                    if (value.Length < 4)
                        lastName = "";
                    else
                        lastName = value;
                }
            }

            public string FullName()
            {
                return FirstName + " " + lastName;
            } 
        }

        public class Triangle
        {
            public int BaseLine { get; private set; }
            public int Height { get; private set; }

            public Triangle()
            {
                BaseLine = 1;
                Height = 1;
            }

            public double Area
            {
                get { return BaseLine * Height * 0.5; }
            }

        }
    }
}
