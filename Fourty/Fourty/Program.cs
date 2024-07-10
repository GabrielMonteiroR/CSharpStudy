using Fourty.model; 
using System;

namespace Fourty
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person("Goku", 21);
            Person personTwo = new Person("Gohan", 22);

            Console.WriteLine("PERSON 1");
            Person.DescribePerson(person);

            Console.WriteLine();

            Console.WriteLine("PERSON 2");
            Person.DescribePerson(personTwo);
        }
    }
}
