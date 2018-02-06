using System;

namespace InheritanceDice
{
    public class Dice
    {
        private int value;
        private static Random rnd;

        static Dice()
        {
            rnd = new Random();
        }

        public Dice()
        {
            Throw();
        }

        public int Value
        {
            get { return value; }
            set
            {
                if (this.value < 1 || value > 6)
                {
                    this.value = value;
                }
            }
        }

        public void Throw() => Value = rnd.Next(1, 7);

        public virtual void Publish()
        {
            Console.WriteLine(Value);
        }
    }
}
