using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //var product = new Product("Jonas", 1000);
            var product = new Product();
            product.Price = 100;
            Console.WriteLine(product.PriceInclTax());
            Console.ReadLine();
        }
    }

    public class Product
    {
        private string name;
        private double price;

        public Product() { }
    
        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public string Name
        {
            get
            {
                Console.WriteLine("logging");
                return name;
            }
            set
            {
                Console.WriteLine("logging");
                name = value;
            }
        }

        public double Price
        {
            get
            {
                Console.WriteLine("logging");
                return price;
            }
            set
            {
                Console.WriteLine("logging");
                price = value;
            }
        }

        public double PriceInclTax()
        {
            return price * 1.25;
        }
    }
}
