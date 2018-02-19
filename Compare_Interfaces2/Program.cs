using System;

namespace Compare_Interfaces2
{
    class Program 
    {

        static void Main(string[] args)
        {
            Dog[] dogs = new Dog[2];
            dogs[0] = new Dog() { Age = 10, Name = "Bulder" };
            dogs[1] = new Dog() { Age = 5, Name = "Lady" };
            Array.Sort(dogs);

            foreach (var dog in dogs)
            {
                Console.WriteLine(dog.Name);
            }

            Console.ReadLine();
        }
    }

    class Dog : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            Dog dog = obj as Dog;
            if (dog.Age > this.Age)
                return -1;
            if (dog.Age < this.Age)
                return 1;
            return 0;
        }
    }
}
