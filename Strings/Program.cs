using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Mikkel";
            string lastName = "Cronberg";
            string fullName = firstName + " " +lastName;
            Console.WriteLine(fullName);
            Console.WriteLine(fullName.ToLower());
            Console.WriteLine(fullName.ToUpper());
            Console.WriteLine(fullName.Substring(7, 4));
            string[] nameArray = fullName.Split(' ');

            foreach (string name in nameArray)
            {
                Console.WriteLine(name);
            }

            System.IO.File.WriteAllText(@"C:\temp\temp.txt", fullName);

            Console.ReadLine();
            

        }
    }
}
