using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesApplication
{
    class DelegateSample
    {
        public delegate void addNum(int x , int y );
        public static void add(int a, int b)
        {
            Console.WriteLine("Addition = " + (a + b));
        }
        static void Main()
        {
            addNum adds = new addNum(DelegateSample.add);
            adds(12, 23);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
