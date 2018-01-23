using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloads
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Add(2, 2, 2, 2);
            Console.WriteLine(x);
            Console.ReadLine();
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Add(int a, int b, int c)
        {
            return Add(a, b) + c;
        }
        static int Add(int a, int b, int c, int d)
        {
            return Add(a, b, c) + d;
        }
    }


}
