using System;

namespace Module10_Interfaces
{
    class Program
    {
        private static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            log.Debug("App start");

            IDatabaseFunction[] collection = new IDatabaseFunction[3];
            collection[0] = new Dog();
            collection[1] = new Dog();
            collection[2] = new Submarine();

            foreach (var item in collection)
            {
                item.Save();
            }

            log.Debug("App stop");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }

    interface IDatabaseFunction
    {
        void Save();
    }

    class Dog : IDatabaseFunction
    {
        public string Name { get; set;}

        public void Save()
        {
            Console.WriteLine("Saving dog");
        }
    }

    class Submarine : IDatabaseFunction
    {
        public int Number { get; set; }
        public double Turbine { get; set; }

        public void Save()
        {
            Console.WriteLine("Saving submarine");
        }
    }

}
