using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandboxbasics1
{
    internal class AnonymousMethodDemo
    {
        public delegate void Print(int value);
        internal static void AnonymousMethod1()
        {
            Print print = delegate (int val)
            {
                Console.WriteLine("Inside Anonymous method :value {0}", val);
            };
            print(100);
        }
    }
}
