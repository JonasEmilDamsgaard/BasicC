namespace Module08_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.FirstName = "Jonas";
            person.LastName = "Damsgaard";
            System.Console.WriteLine(person.FullName());

            var student = new Student();
            student.FirstName = "Pernille";
            student.LastName = "Damsgaard";
            System.Console.WriteLine(student.FullName());

            var instructor = new Instructor();
            instructor.FirstName = "Emil";
            instructor.LastName = "Damsgaard";
            System.Console.WriteLine(instructor.FullName());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }

    public class Student : Person
    {
        public string ClassRoom { get; set; }
    }

    public class Instructor : Person
    {
        public string KeyID { get; set; }
    }
}
