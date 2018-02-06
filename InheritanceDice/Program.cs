using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDice
{
    class Program
    {
        static void Main(string[] args)
        {
            var ludoDice = new LudoDice();
            ludoDice.Publish();
            Console.ReadLine();
        }
    }

    public class LudoDice : Dice
    { 
        public bool IsGlobe()
        {
            return Value == 3;
        }

        public bool IsStar()
        {
            return Value == 5;
        }

        public override void Publish()
        {
            switch (Value)
            {
                case 3:
                    Console.WriteLine("G");
                    break;
                case 5:
                    Console.WriteLine("S");
                    break;
                default:
                    base.Publish();
                    break;
            }
        }
    }
}
