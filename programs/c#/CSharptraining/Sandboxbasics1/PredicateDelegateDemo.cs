using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandboxbasics1
{
    internal class PredicateDelegateDemo
    {

        internal static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());

        }

        internal static void PredicateDelegate()
        {
            Predicate<string> isUpper = IsUpperCase;
            bool result = isUpper("HELLO WORLD");
            Console.WriteLine(result);
        }
    }
}
