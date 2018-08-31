using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegatesApplication
{
    class Program
    {
        public static object MessageBox
        {
            get;
            private set;
        }
        static void Main(string[] args)
        {
            var a = 1;
            string num2;
            ConcurrentDictionary<int, string> dictionary = new ConcurrentDictionary<int, string>();
            Console.WriteLine("Enter how many values you want to add ");
            int count = Convert.ToInt32(Console.ReadLine());
            int l ;
            for (l = 0; l <= count; l++)
            {
                Console.WriteLine("enter the key :");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value");
                num2 = Console.ReadLine();

                Added(a, num2);
            }
            void Added(int i, string s)
            {
                try
                {
                    
                    var keys = i.GetHashCode();
                    var values = s.ToString();
                    dictionary.AddOrUpdate(keys, values, (k,v) => values);
                    Console.WriteLine("Keys :" + keys + " Values : " + values);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("updated");
                }
            }
            foreach (KeyValuePair<int, string> value in dictionary)
            {
                Console.WriteLine("{0} - \"{1}\"", value.Key, value.Value);
            }
            Console.Read();



        } //class
    }
}

