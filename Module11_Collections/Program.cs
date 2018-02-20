using System.Collections.Generic;

namespace Module11_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            list.Add(new Person() { Id = 1, Name = "Jonas"});
            list.Add(new Person() { Id = 2, Name = "Pernille" });

            foreach (var pers in list)
            {
                System.Console.WriteLine(pers.Name);
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        Dictionary<>
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
