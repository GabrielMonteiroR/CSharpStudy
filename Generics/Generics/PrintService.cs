using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class PrintService
    {
        private int[] _values = new int[10];
        private int _count = 0;

        public void addValue(int value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;
        }

        public int First()
        {
            if (_values != null && _values.Length > 0)
            {
                return _values[0];
            }
            else
            {
                throw new InvalidOperationException("PrintService is empty");
            }
        }
            public void Print()
            {
                for (int i = 0; i < _count - 1; i++) {
                Console.WriteLine(_values[i]);
            }
        }



    }

}
