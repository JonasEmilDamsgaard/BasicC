using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int nextNumber = 0;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    nextNumber = j * i;

                    if (nextNumber >= 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.Write(nextNumber.ToString().PadLeft(5));
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
