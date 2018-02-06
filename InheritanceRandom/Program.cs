using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            var extendedRandom = new ExtendedRandom();
            Console.WriteLine(extendedRandom.NextBool());
            Console.ReadLine();
        }
    }

    public class ExtendedRandom : Random
    {
        public bool NextBool()
        {
            if (Next(1, 1002) < 500)
                return true;
            else
                return false;
        }
    }
}
