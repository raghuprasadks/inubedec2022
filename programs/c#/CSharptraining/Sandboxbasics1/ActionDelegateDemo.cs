using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandboxbasics1
{
    internal class ActionDelegateDemo
    {
       internal static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }

        internal static void ActionDelegate()
        {
            Action<int> printActionDel = ConsolePrint;
            printActionDel(10);
        }
    }
}
