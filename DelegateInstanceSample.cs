using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesApplication
{
    public delegate int MulDelegate(int x, int y);
    class DelegateInstanceSample
    {
        public static int Mul(int x , int y)
        {
            return x * y ;
        }
        public int Div(int x , int y )
        {
            return x / y;
        }
        static void Main()
        {
            DelegateInstanceSample delegateInstanceSample = new DelegateInstanceSample();
            MulDelegate mulDelegate = new MulDelegate(DelegateInstanceSample.Mul);
            Console.WriteLine(mulDelegate(10, 20));
            Console.WriteLine(delegateInstanceSample.Div(20, 10));
            Console.ReadKey();
        }
    }
}
