using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesApplication
{
    class RemoveDelegateSample
    {
        public delegate void ShowMessage(string s);
        public void Message1(string s)
        {
            Console.WriteLine("Message1(string)" + s);
        }
        public void Message2(string s)
        {
            Console.WriteLine("Message2(string)" + s);

        }
        public void Message3(string s)
        {
            Console.WriteLine("Message3(string)"  + s);
        }
        static void Main()
        {
            RemoveDelegateSample removeDelegateSample = new RemoveDelegateSample();
            RemoveDelegateSample.ShowMessage message = null;
            message += new RemoveDelegateSample.ShowMessage(removeDelegateSample.Message1);
            message += new RemoveDelegateSample.ShowMessage(removeDelegateSample.Message2);
            message += new RemoveDelegateSample.ShowMessage(removeDelegateSample.Message3);
            message("Hello Multicast Delegates");
            message -= new RemoveDelegateSample.ShowMessage(removeDelegateSample.Message2);
            message("=================");
            message("Message 2 Removed");
            Console.ReadKey();

        }
    }
}
