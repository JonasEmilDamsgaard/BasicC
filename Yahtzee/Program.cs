using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Program
    {
        static void Main(string[] args)
        {
            var Cup = new Cup();
            Cup.CurrentValues();
            Console.ReadLine();
        }
    }

    public class Dice
    {
        private int eyes;
        private static Random rnd = new Random();

        public Dice()
        {
            this.eyes = 1;
            Throw();
        }

        public void Throw()
        {
            eyes = rnd.Next(1, 7);
        }

        public void CurrentValue()
        {
            Console.WriteLine("[" + this.eyes + "]");
        }
        
        public int Eyes
        {
            get { return eyes; }
            set { eyes = value; }
        }

    }

    public class Cup
    {
        private Dice[] dices = new Dice[5];

        public Cup()
        {
            for (int i = 0; i < 5; i++)
            {
                dices[i] = new Dice();
            }
        }

        public void CurrentValues()
        {
            foreach (var dice in dices)
            {
                Console.WriteLine(dice.Eyes);
            }
        }
    }
}
