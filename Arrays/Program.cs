using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 10, 7, 6, 3, 1, 50, 3 };
            var res = CalculateAndSortArray(test);

        }

        public static ArrayResult CalculateAndSortArray(int[] input)
        {
            ArrayResult arrayResult;
            arrayResult.Sum = 0;
            arrayResult.Avg = 0;

            foreach (var nextInput in input)
            {
                arrayResult.Sum += nextInput;
            }
            arrayResult.Avg = arrayResult.Sum / input.Length;

            Array.Sort(input);
            return arrayResult;


        }

    }

    struct ArrayResult
    {
        public double Sum;
        public double Avg;
    }
}
