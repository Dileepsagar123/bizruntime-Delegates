﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesApplication
{
    public delegate int dgPointer(int a, int b);

    class FullAdder
    {
        static void Main()
        {
            Adder a = new Adder();
            dgPointer pAdder = new dgPointer(a.Add);
            int iAnswer = pAdder(4, 3);
            Console.WriteLine("iAnswer = {0}", iAnswer);
            // Returns “iAnswer = 7”
        }
    }

    public class Adder
    {
        public int Add(int x, int y)
        { return x + y; }
    }
}
