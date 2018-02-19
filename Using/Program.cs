using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader stream = File.OpenText(@"x:\dyrenavne.txt"))
            {
                while (stream.Peek() != -1)
                {
                    string Name = stream.ReadLine();
                    Console.WriteLine(Name);
                }
            }

            

            Console.ReadLine();
        }
    }
}
