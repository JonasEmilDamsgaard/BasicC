using System;

namespace Module12_Delegates
{
    class Program
    {
        // public delegate int Calculation(int a, int b);

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Substract(int a, int b)
        {
            return a - b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        //public static int Calculate(int a, int b, Calculation mathFunction)
        public static int Calculate(int a, int b, Func<int, int, int> mathFunction)
        {
            return mathFunction(a, b);
        }




        static void Main(string[] args)
        {
            int result = 0;
            result = Calculate(1, 1, Add);
            System.Console.WriteLine(result);

            result = Calculate(1, 1, Substract);
            System.Console.WriteLine(result);

            result = Calculate(1, 1, Divide);
            System.Console.WriteLine(result);

            result = Calculate(1, 1, Multiply);
            System.Console.WriteLine(result);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
