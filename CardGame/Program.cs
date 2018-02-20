using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Card
    {
        public string Suit { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return this.Suit + " " + this.Value;
        }
    }

    public class Cardstack
    {
        private Stack<Card> cardstack = new Stack<Card>();
        public void Add(Card card)
        {
            cardstack.Push(card);
        }

        public void Remove()
        {
            if (cardstack.Count > 0)
            {
                cardstack.Pop();
            }
        }

        public void Show()
        {
            if (cardstack.Count > 0)
            {
                foreach (var card in cardstack)
                {
                    Console.WriteLine(card.Suit + " " + card.Value);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cardstack cardstack = new Cardstack();
            cardstack.Add(new Card() { Suit = "Spade", Value = 2 });
            cardstack.Add(new Card() { Suit = "Heart", Value = 14 });
            cardstack.Add(new Card() { Suit = "Diamond", Value = 3 });
            cardstack.Show();

            cardstack.Remove();

            cardstack.Show();
            Console.ReadLine();
        }
    }
}
