using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    public static class ArealBeregninger
    {
        public static double BeregnArealFirkant(double højde, double brede)
        {
            return højde * brede;
        }

        public static double BeregnArealCirkel(double radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArealBeregninger.BeregnArealFirkant(10, 10));
            Console.WriteLine(ArealBeregninger.BeregnArealCirkel(5));
            Console.ReadLine();
        }
    }
}
