using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesApplication
{
    class AnnonymousDelegatesSample
    {
        public delegate void Del(int n);
        static void Main()
        {
            Del del = delegate(int x) { Console.WriteLine("This is annonymous Method"); };
            Console.ReadKey();
        }
    }
}
