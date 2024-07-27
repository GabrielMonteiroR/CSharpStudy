using System;
using DelegatePredicate.Entities;

namespace DelegatePredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("Hd Case", 80.90));

            list.RemoveAll(ProductTest);

            foreach (Product product in list)
            {
                System.Console.WriteLine(product);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}


