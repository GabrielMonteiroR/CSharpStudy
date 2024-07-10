using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourty.model
{
    public class Person
    {
        private string _name;
        private int _age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public static void DescribePerson(Person person)
        {
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }

    }
}
