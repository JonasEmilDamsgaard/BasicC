using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] database = { 1000, 2000, 2800 };
            double result = avg(database);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static double avg(int[] monthlysalary)
        {
            int m = 0;
            foreach (int nextSalary in monthlysalary)
            {
                m = m + nextSalary;
            }
            
            return m / monthlysalary.Length;
        }
    }
}
