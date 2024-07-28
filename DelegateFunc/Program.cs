using System;
using System.Runtime.CompilerServices;
using DelegateAction.Entities;

namespace DelegateAction
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

// // <RECEBE,RETORNA>                     recebe      faz
//             Func<Product,string> func = product => product.Name.ToUpper();
//             //Se ja faz return nao precisa {}

            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string item in result) 
            {
                System.Console.WriteLine(item);
            }
            


        }
    }

}

