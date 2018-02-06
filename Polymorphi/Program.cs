using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphi
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            dog.Name = "Lars";
            dog.SaySomething();
        }
    }

    public class Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual void SaySomething()
        {
            Console.WriteLine("I am an animal and my name is " + Name.ToString());
            Console.ReadLine();
        }

        public static Animal RandomAnimal()
        {
            string path = @"x:\dyrenavne.txt";
            string[] names = System.IO.File.ReadAllLines(path);
            return new Dog();
        }

    }

    public class Dog : Animal
    {
        public override void SaySomething()
        {
            Console.WriteLine("I am an animal and my name is " + Name.ToString());
            Console.ReadLine();
        }
    }

    public class Cat : Animal
    {
        public override void SaySomething()
        {
            Console.WriteLine("I am an animal and my name is " + Name.ToString());
            Console.ReadLine();
        }
    }
}
