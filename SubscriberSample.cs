using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesApplication
{
    //This is Subscriber Class
    class SubscriberSample
    {
        static void Main(string[] args)
        {
            Publisher a = new Publisher();
            //Event gets binded with delegates
            a.ev_OddNumber += new Publisher.dg_OddNumber(EventMessage);
            a.Add();
            Console.Read();
        }
        //Delegates calls this method when event raised.  
        static void EventMessage()
        {
            Console.WriteLine("********Event Executed : This is Odd Number**********");
        }
    }
    //This is Publisher Class
    class Publisher
    {
        public delegate void dg_OddNumber(); //Declared Delegate     
        public event dg_OddNumber ev_OddNumber; //Declared Events

        public void Add()
        {
            int result;
            result = 5 + 4;
            Console.WriteLine(result.ToString());
            //Check if result is odd number then raise event
            if ((result % 2 != 0) && (ev_OddNumber != null))
            {
                ev_OddNumber(); //Raised Event
            }
        }
    }
}
