using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesApplication
{
    class GenericDelegateSample
    {
        public delegate string GenericDelegateNumber<T1, T2>(T1 a, T2 b);
        public static string AddDoubles(double a, double b)
        {
            return (a + b).ToString();
        }

        public static string AddInt(int a, int b)
        {
            return (a + b).ToString();
        }

    }
}
